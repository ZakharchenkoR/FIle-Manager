using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalCom
{
    class Editer
    {
       // public string StrAfterEdit { get; set; } = string.Empty;
        public string EditString(string str)
        {
            if (str[str.Length - 1] == '\\')
            {
                str = str.Remove(str.Length - 1, 1);
                while (str[str.Length - 1] != '\\')
                {
                   str = str.Remove(str.Length - 1, 1);

                }
            }
            else if (str[str.Length - 1] != '\\')
            {
                while (str[str.Length - 1] != '\\')
                {
                    str = str.Remove(str.Length - 1, 1);
                }
            }
            return str;
        }
    }
}

//if (textBox_Path_2.Text[textBox_Path_2.Text.Length - 1] == '\\')
//{
//    textBox_Path_2.Text = textBox_Path_2.Text.Remove(textBox_Path_2.Text.Length - 1, 1);
//    while (textBox_Path_2.Text[textBox_Path_2.Text.Length - 1] != '\\')
//    {
//        textBox_Path_2.Text = textBox_Path_2.Text.Remove(textBox_Path_2.Text.Length - 1, 1);

//    }
//}
//else if (textBox_Path_2.Text[textBox_Path_2.Text.Length - 1] != '\\')
//{
//    while (textBox_Path_2.Text[textBox_Path_2.Text.Length - 1] != '\\')
//    {
//        textBox_Path_2.Text = textBox_Path_2.Text.Remove(textBox_Path_2.Text.Length - 1, 1);
//    }
//}
