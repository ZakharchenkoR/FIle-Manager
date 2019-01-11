using System;
using System.Windows.Forms;

namespace TotalCom
{
    public partial class Form2 : Form
    {
        IFormData parentForm;
        public Form2(IFormData f)
        {
            InitializeComponent();           
            parentForm = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parentForm.AddText(textBox1.Text);
            Close();
        }
    }
}
