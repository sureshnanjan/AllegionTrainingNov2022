using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroku.Operations
{
    public interface IABTesting
    {
        void verifyParagraph();
        void verifyHeading();
        string Paragraph { get; }
    }
}
