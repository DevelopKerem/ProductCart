using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProductUI.Service
{
    public class FileUpload : IFileUpload
    {

        public async Task<string> UploadFile(IBrowserFile file)
        {
                FileInfo fileInfo = new FileInfo(file.Name);
                var filename = fileInfo.Name;

                var memoryStream = new MemoryStream();
                await file.OpenReadStream().CopyToAsync(memoryStream);

                var fullPath = $"{filename}";
                return fullPath;
            }
        }
    }
