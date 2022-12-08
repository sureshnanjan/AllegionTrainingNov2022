using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuApp.Operations;

namespace HerokuApp.Operations
{
    public interface IFileUpload
    {
        void verifyHeader();
        void verifyParagraph();
        void verifyChooseFileButton();
        void verifyUploadButton();
        void verifyContentSpace();
    }
}
