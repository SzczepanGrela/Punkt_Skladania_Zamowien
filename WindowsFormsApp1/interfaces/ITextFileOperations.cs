using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1.interfaces
{
    internal interface ITextFileOperations
    {

        void WriteFile(params string[] content);   // params keyword allows to pass single string as well as array of strings
        void UpdateFile(int[] lines, params string[] content);
        void AppendToFile(params string[] content);
        string[] ReadFile();


    }
}
