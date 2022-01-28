using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductUI.Service
{
    public interface IFileUpload
    {
        Task<string> UploadFile(IBrowserFile file);
    }
}
