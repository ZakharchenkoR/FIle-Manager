using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TotalCom
{
    class FileManipulator : IMovie
    {
        public void CopyFile(string a, string b)
        {
            DirectoryInfo source = new DirectoryInfo($"{a}\\");
            // MessageBox.Show(a);
            DirectoryInfo destin = new DirectoryInfo($"{b}\\");
            //MessageBox.Show(b);
            foreach (var item in source.GetFiles())
                item.CopyTo(destin + item.Name, true);
        }
    }
}
