using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BreakProintUploadAndDownload.Models;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Cors;

namespace BreakProintUploadAndDownload.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private static readonly object lockObj = new object();
        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public  IActionResult  UploadAttachment([FromForm]FileChunksModel  model)
        {
            if(model.file == null)
            {
                return BadRequest();
            }
            if (model.chunked)
            {
                //var file = Request.Form.Files[0];
                var file = model.file;
                //取得chunk和chunks
                int chunk = Convert.ToInt32(Request.Form["chunk"]);//当前分片在上传分片中的顺序（从0开始）
                int chunks = Convert.ToInt32(Request.Form["chunks"]);//总分片数
                var folder = Path.Combine(_hostingEnvironment.WebRootPath, "chunk\\" + Request.Form["uid"] + "\\");
                string path = folder + chunk;
                //建立临时传输文件夹
                if (!Directory.Exists(Path.GetDirectoryName(folder)))
                {
                    Directory.CreateDirectory(folder);
                }

                FileStream addFile = null;
                BinaryWriter AddWriter = null;
                Stream stream = null;
                BinaryReader TempReader = null;

                try
                {
                    //addFile = new FileStream(path, FileMode.Append, FileAccess.Write);
                    addFile = new FileStream(path, FileMode.Create, FileAccess.Write);
                    AddWriter = new BinaryWriter(addFile);
                    //获得上传的分片数据流
                    stream = model.file.OpenReadStream();
                    TempReader = new BinaryReader(stream);
                    //将上传的分片追加到临时文件末尾
                    AddWriter.Write(TempReader.ReadBytes((int)stream.Length));
                }
                finally
                {
                    if (addFile != null)
                    {
                        addFile.Close();
                        addFile.Dispose();
                    }
                    if (AddWriter != null)
                    {
                        AddWriter.Close();
                        AddWriter.Dispose();
                    }
                    if (stream != null)
                    {
                        stream.Close();
                        stream.Dispose();
                    }
                    if (TempReader != null)
                    {
                        TempReader.Close();
                        TempReader.Dispose();
                    }
                }
                return Ok(new { nextchunk = chunk + 1 });
            }
            else
            {
                // 文件大小
                long size = 0;
                //var file = Request.Form.Files[0];
                var filename = ContentDispositionHeaderValue.Parse(model.file.ContentDisposition).FileName;
                // 扩展名
                var extName = filename.Substring(filename.LastIndexOf('.')).Replace("\"", "");

                // 新文件名
                string shortfilename = $"{Guid.NewGuid()}{extName}";

                var filePath = Path.Combine(_hostingEnvironment.WebRootPath, shortfilename);
                //保存到绝对路径

                // 设置文件大小
                size += model.file.Length;

                // 创建新文件
                using (FileStream fs = System.IO.File.Create(filePath))
                {
                    // 复制文件
                    model.file.CopyTo(fs);
                    // 清空缓冲区数据
                    fs.Flush();
                }

                return Ok("上传完成！");
            }

        }

        [HttpPost]
        public IActionResult ValidateFile([FromBody]ValidateFileModel model)
        {
            var folder = Path.Combine(_hostingEnvironment.WebRootPath, "chunk\\" + model.uid + "\\");
            // 扩展名
            var extName = model.fileName.Substring(model.fileName.LastIndexOf('.')).Replace("\"", "");
            if (Directory.GetFiles(folder).Length == model.chunks)//总文件数等于总切片数
            {
                model.extName = extName;
                var filename = MergeFiles(model);
                return Ok(new { isValid = true });
            }
            else
                return Ok(new { isValid = false });
        }

        public string MergeFiles(ValidateFileModel model)
        {
            string sourcePath = Path.Combine(_hostingEnvironment.WebRootPath, "chunk\\" + model.uid + "\\");//源数据文件夹
            string fileName = Guid.NewGuid().ToString();
            string targetPath = Path.Combine(_hostingEnvironment.WebRootPath, $"{fileName}.{model.extName}");//合并后的文件
            

            DirectoryInfo dicInfo = new DirectoryInfo(sourcePath);
            if (Directory.Exists(Path.GetDirectoryName(sourcePath)))
            {
                FileInfo[] files = dicInfo.GetFiles();
                foreach (FileInfo file in files.OrderBy(f => int.Parse(f.Name)))
                {
                    FileStream addFile = new FileStream(targetPath, FileMode.Append, FileAccess.Write);
                    BinaryWriter AddWriter = new BinaryWriter(addFile);

                    //获得上传的分片数据流 
                    Stream stream = file.Open(FileMode.Open);
                    BinaryReader TempReader = new BinaryReader(stream);
                    //将上传的分片追加到临时文件末尾
                    AddWriter.Write(TempReader.ReadBytes((int)stream.Length));
                    //关闭BinaryReader文件阅读器
                    TempReader.Close();
                    stream.Close();
                    AddWriter.Close();
                    addFile.Close();

                    TempReader.Dispose();
                    stream.Dispose();
                    AddWriter.Dispose();
                    addFile.Dispose();
                }
                DeleteFolder(sourcePath);
                return fileName;
            }
            else
            {
                throw new IOException("找不到数据块");
            }
        }

        private void DeleteFolder(string strPath)
        {
            //删除这个目录下的所有子目录
            if (Directory.GetDirectories(strPath).Length > 0)
            {
                foreach (string fl in Directory.GetDirectories(strPath))
                {
                    Directory.Delete(fl, true);
                }
            }
            //删除这个目录下的所有文件
            if (Directory.GetFiles(strPath).Length > 0)
            {
                foreach (string f in Directory.GetFiles(strPath))
                {
                    System.IO.File.Delete(f);
                }
            }
            Directory.Delete(strPath, true);
        }

        public IActionResult Upload()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
