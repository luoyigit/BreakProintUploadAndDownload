#pragma checksum "D:\代码\断点续传\BreakProintUploadAndDownload\BreakProintUploadAndDownload\Views\Home\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0416e93a79f003fc5b5aea36f088d7fb1f35433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Upload), @"mvc.1.0.view", @"/Views/Home/Upload.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Upload.cshtml", typeof(AspNetCore.Views_Home_Upload))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\代码\断点续传\BreakProintUploadAndDownload\BreakProintUploadAndDownload\Views\_ViewImports.cshtml"
using BreakProintUploadAndDownload;

#line default
#line hidden
#line 2 "D:\代码\断点续传\BreakProintUploadAndDownload\BreakProintUploadAndDownload\Views\_ViewImports.cshtml"
using BreakProintUploadAndDownload.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0416e93a79f003fc5b5aea36f088d7fb1f35433", @"/Views/Home/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7031fc13f0162bff7677124a45d8ba3c0c453948", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\代码\断点续传\BreakProintUploadAndDownload\BreakProintUploadAndDownload\Views\Home\Upload.cshtml"
   
    Layout = null;

#line default
#line hidden
            BeginContext(28, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(53, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0416e93a79f003fc5b5aea36f088d7fb1f354333590", async() => {
                BeginContext(59, 146, true);
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <!-- import CSS -->\r\n    <link rel=\"stylesheet\" href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(212, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(214, 438, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0416e93a79f003fc5b5aea36f088d7fb1f354334928", async() => {
                BeginContext(220, 425, true);
                WriteLiteral(@"
    <div id=""app"">
        <el-upload drag
                   multiple
                   :auto-upload=""true""
                   :http-request=""checkedFile""
                   :before-remove=""removeFile""
                   :limit=""10""
                   action=""/"">
            <i class=""el-icon-upload""></i>
            <div class=""el-upload__text"">将文件拖到此处，或<em>点击上传</em></div>
        </el-upload>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(652, 7041, true);
            WriteLiteral(@"
<!-- import Vue before Element -->
<script src=""https://cdn.bootcss.com/axios/0.18.0/axios.js""></script>
<script src=""https://unpkg.com/vue/dist/vue.js""></script>
<!-- import JavaScript -->
<script src=""https://unpkg.com/element-ui/lib/index.js""></script>
<script>
    new Vue({
        el: '#app',
        data() {
            return {
                maxSize: 5 * 1024 * 1024 * 1024, // 上传最大文件限制
                multiUploadSize: 20 * 1024 * 1024, // 大于这个大小的文件使用分块上传(后端可以支持断点续传)
                eachSize: 20 * 1024 * 1024, // 每块文件大小
                requestCancelQueue: [], // 请求方法队列（调用取消上传
            }
        },
        mounted() {
        },
        methods: {
            async checkedFile(options) {

                const { maxSize, multiUploadSize, getSize, splitUpload, singleUpload } = this
                const { file, onProgress, onSuccess, onError } = options

                if (file.size > maxSize) {
                    return this.$message({
                        message: `");
            WriteLiteral(@"您选择的文件大于${getSize(maxSize)}`,
                        type: 'error'
                    })
                }
                const uploadFunc = file.size > multiUploadSize ? splitUpload : singleUpload
                try {
                    await uploadFunc(file, onProgress)
                    this.$message({
                        message: '上传成功',
                        type: 'success'
                    })
                    onSuccess()
                } catch (e) {
                    console.error(e)
                    this.$message({
                        message: e.message,
                        type: 'error'
                    })
                    onError()
                }
                const prom = new Promise((resolve, reject) => { })
                prom.abort = () => { }
                return prom
            },
            // 格式化文件大小显示文字
            getSize(size) {
                return size > 1024
                    ? size / 1024 > 1024
          ");
            WriteLiteral(@"              ? size / (1024 * 1024) > 1024
                            ? (size / (1024 * 1024 * 1024)).toFixed(2) + 'GB'
                            : (size / (1024 * 1024)).toFixed(2) + 'MB'
                        : (size / 1024).toFixed(2) + 'KB'
                    : (size).toFixed(2) + 'B'
            },
            // 单文件直接上传
            singleUpload(file, onProgress) {
                return this.postFile({ file, uid: file.uid, fileName: file.fileName }, onProgress)
            },
            // 大文件分块上传
            splitUpload(file, onProgress) {
                return new Promise(async (resolve, reject) => {
                    try {
                        const { eachSize } = this
                        const chunks = Math.ceil(file.size / eachSize)
                        const fileChunks = await this.splitFile(file, eachSize, chunks)
                        let currentChunk = 0
                        alert(fileChunks.length);
                        for (let i = 0; i < fileCh");
            WriteLiteral(@"unks.length; i++) {
                            // 服务端检测已经上传到第currentChunk块了，那就直接跳到第currentChunk块，实现断点续传
                            console.log(currentChunk, i)
                            if (Number(currentChunk) === i) {
                                // 每块上传完后则返回需要提交的下一块的index
                                currentChunk = await this.postFile({
                                    chunked: true,
                                    chunk: i,
                                    chunks,
                                    eachSize,
                                    fileName: file.name,
                                    fullSize: file.size,
                                    uid: file.uid,
                                    file: fileChunks[i]
                                }, onProgress)
                            }
                        }
                        const isValidate = await this.validateFile({
                            chunks: fileChunks.length,
                  ");
            WriteLiteral(@"          fileName: file.name,
                            fullSize: file.size,
                            uid: file.uid
                        })
                        if (!isValidate) {
                            throw new Error('文件校验异常')
                        }
                        resolve()
                    } catch (e) {
                        reject(e)
                    }
                })
            },
            // 文件分块,利用Array.prototype.slice方法
            splitFile(file, eachSize, chunks) {
                return new Promise((resolve, reject) => {
                    try {
                        setTimeout(() => {
                            const fileChunk = []
                            for (let chunk = 0; chunks > 0; chunks--) {
                                fileChunk.push(file.slice(chunk, chunk + eachSize))
                                chunk += eachSize
                            }
                            resolve(fileChunk)
                 ");
            WriteLiteral(@"       }, 0)
                    } catch (e) {
                        console.error(e)
                        reject(new Error('文件切块发生错误'))
                    }
                })
            },
            removeFile(file) {
                this.requestCancelQueue[file.uid]()
                delete this.requestCancelQueue[file.uid]
                return true
            },
            // 提交文件方法,将参数转换为FormData, 然后通过axios发起请求
            postFile(param, onProgress) {
                const formData = new FormData()
                for (let p in param) {
                    formData.append(p, param[p])
                }
                const { requestCancelQueue } = this
                const config = {
                    cancelToken: new axios.CancelToken(function executor(cancel) {
                        if (requestCancelQueue[param.uid]) {
                            requestCancelQueue[param.uid]()
                            delete requestCancelQueue[param.uid]
                 ");
            WriteLiteral(@"       }
                        requestCancelQueue[param.uid] = cancel
                    }),
                    onUploadProgress: e => {
                        if (param.chunked) {
                            e.percent = Number(((((param.chunk * (param.eachSize - 1)) + (e.loaded)) / param.fullSize) * 100).toFixed(2))
                        } else {
                            e.percent = Number(((e.loaded / e.total) * 100).toFixed(2))
                        }
                        onProgress(e)
                    }
                }
                return axios.post('/Home/UploadAttachment', formData, config).then(rs => rs.data.nextchunk);

            },
            // 文件校验方法
            validateFile(file) {
                return axios.post('/Home/ValidateFile', file).then(rs => rs.data.isValid);
            }
        }
    })

</script>


</html >");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
