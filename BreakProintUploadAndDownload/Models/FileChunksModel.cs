using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakProintUploadAndDownload.Models
{
    public class FileChunksModel
    {
        public bool chunked { get; set; }
        public int chunk { get; set; }
        public int chunks { get; set; }
        public long eachSize { get; set; }
        public string fileName { get; set; }
        public long fullSize { get; set; }
        public string uid { get; set; }
        public IFormFile file { get; set; }
    }


    public class ValidateFileModel
    {
        public int chunks { get; set; }
        public string fileName { get; set; }
        public long fullSize { get; set; }
        public string uid { get; set; }

        public string extName { get; set; }


    }
}
