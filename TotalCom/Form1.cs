using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TotalCom
{
    public partial class Form1 : Form,IFormData
    {
        Editer editer;
        FontDialog font;
        ColorDialog color;
        Form2 form2;
        SaveFileDialog save_file;
        ICalc calc = new Calculator();
        IMovie movie = new FileManipulator();      
        DriveInfo [] drive;
        DriveInfo[] drive_2;
        DirectoryInfo dirInfo;
        string path = string.Empty;
        string path_2 = string.Empty;
        string create_new_catalog_or_file = string.Empty;
        string bufer = string.Empty;
        const double gigabyte = 1073741824;
        ListViewItem lvi;
        ListViewItem lvi_2;

        int index_catalog_position;
        public Form1()
        {
            InitializeComponent();
            editer = new Editer();
            drive = DriveInfo.GetDrives();
            drive_2 = DriveInfo.GetDrives();
            font = new FontDialog();
            color = new ColorDialog();
            save_file = new SaveFileDialog();
            listView1.SmallImageList = imageList1;
            listView1.Columns.Add("Name", 250);
            listView1.Columns.Add("Size", 50);
            listView1.Columns.Add("Drive type", 80);
            listView1.Columns.Add("Normal", 100);

            listView2.SmallImageList = imageList1;
            listView2.Columns.Add("Name", 250);
            listView2.Columns.Add("Size", 50);
            listView2.Columns.Add("Drive type", 80);
            listView2.Columns.Add("Normal", 100);

            foreach (var dr in drive)
            {
                lvi = new ListViewItem(new string[] { dr.Name,
                    ( Math.Round( calc.Divide(dr.TotalSize,gigabyte)).ToString()),
                    dr.DriveType.ToString(),dr.IsReady.ToString()});                 
                lvi.ImageIndex = 0;
                listView1.Items.Add(lvi);
            }
            foreach (var dr in drive_2)
            {
                lvi_2 = new ListViewItem(new string[] { dr.Name,
                    ( Math.Round( calc.Divide(dr.TotalSize,gigabyte)).ToString()),
                    dr.DriveType.ToString(),dr.IsReady.ToString()});
                lvi_2.ImageIndex = 0;
                listView2.Items.Add(lvi_2);
            }


            listView1.ItemSelectionChanged += listView1_SelectedIndexChanged;
            listView2.ItemSelectionChanged += listView2_SelectedIndexChanged;
            del_con_ToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            catalog_ToolStripMenuItem.Click += CreateCatalogToolStripMenuItem_Click;
            file_ToolStripMenuItem1.Click += CreateFileToolStripMenuItem1_Click;
            copy_ToolStripMenuItem1.Click += копироватьToolStripMenuItem_Click;
            paste_ToolStripMenuItem1.Click += paste_ToolStripMenuItem_Click;
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            ListViewItemSelectionChangedEventArgs a = e as ListViewItemSelectionChangedEventArgs;
            if (a != null && a.Item.Selected)
            {
                path = a.Item.Text;
                index_catalog_position = a.ItemIndex;
            }
            textBox_Path_1.Text = path;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListViewItemSelectionChangedEventArgs a = e as ListViewItemSelectionChangedEventArgs;
            if (a != null && a.Item.Selected)
            {
                path_2 = a.Item.Text;
                index_catalog_position = a.ItemIndex;
            }
            textBox_Path_2.Text = path_2;
        }

        private void textBox_Path_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Path.GetExtension(path) == String.Empty)
                {
                    listView1.Items.Clear();
                    GetDirect(path,true);
                }
                else
                {
                    Process.Start(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        ////////////////////////////////////////
        /////возврашение на предедущий каталог лист№1
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Path_1.Text = editer.EditString(textBox_Path_1.Text);
                path = textBox_Path_1.Text;
                listView1.Items.Clear();
                GetDirect(textBox_Path_1.Text,true);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
//возврашение на предедущий каталог лист№2

        private void button_return_to_last_direct_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_Path_2.Text = editer.EditString(textBox_Path_2.Text);
                path_2 = textBox_Path_2.Text;
                listView2.Items.Clear();
                GetDirect(path_2,false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Path.GetExtension(path_2) == String.Empty)
                {
                    listView2.Items.Clear();
                    GetDirect(path_2, false);
                }
                else
                {
                    Process.Start(path_2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void textBox_Path_1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox_Path_1.SelectAll();
            listView2.DoDragDrop(textBox_Path_1.Text, DragDropEffects.All);
        }

        private void listView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
           // listView2.Items.Add(e.Data.GetData(DataFormats.Text).ToString());
            string str1 = $"{textBox_Path_1.Text}";
            string str2 = $"{textBox_Path_2.Text}";
            movie.CopyFile(str1,str2);
            //listView2.Clear();
            GetDirect(path_2, false);
        }


        //удаление файла или каталога

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Удалить?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (listView1.Focused == true)
                    {
                        if (Path.GetExtension(path) == String.Empty)
                        {
                            dirInfo = new DirectoryInfo(textBox_Path_1.Text);
                            dirInfo.Delete(true);
                            
                        }
                        else
                        {
                            File.Delete(textBox_Path_1.Text);
                        }
                        listView1.Items.Clear();
                        textBox_Path_1.Text = editer.EditString(textBox_Path_1.Text);                      
                        path = textBox_Path_1.Text;
                        GetDirect(path, true);
                    }
                    else if (listView2.Focused == true)
                    {
                        if (Path.GetExtension(path_2) == String.Empty)
                        {
                            dirInfo = new DirectoryInfo(textBox_Path_2.Text);
                            dirInfo.Delete(true);
                        }
                        else
                        {
                            File.Delete(textBox_Path_2.Text);
                        }
                        listView2.Items.Clear();
                        textBox_Path_2.Text = editer.EditString(textBox_Path_2.Text);
                        path_2 = textBox_Path_2.Text;
                        GetDirect(path_2, false);
                    }
                }               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 //шрифти и фон
        private void new_shrift_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
            if (font.ShowDialog() == DialogResult.OK)
            {
                groupBox1.Font = font.Font;
            }
        }

        private void new_first_catagog_fon_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(color.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = color.Color;
            }
        }

        private void new_second_catalog_fon_ФонВнутриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                groupBox1.BackColor = color.Color;
            }
        }

        private void fone_catalog1_ФонПервогоКаталогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                groupBox2.BackColor = color.Color;
            }
        }

        private void fone_catagol2_ФонВторогоКаталогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                groupBox3.BackColor = color.Color;
            }
        }
//создание файла
        private void CreateFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                form2 = new Form2(this);
                form2.ShowDialog();
                if (listView1.Focused == true)
                {
                    
                    File.Create(textBox_Path_1.Text +"\\"+ create_new_catalog_or_file+".txt");
                    listView1.Items.Clear();
                    GetDirect(path, true);
                }
                else if (listView2.Focused == true)
                {
                    File.Create(textBox_Path_2.Text + "\\" + create_new_catalog_or_file + ".txt");
                    listView2.Items.Clear();
                    GetDirect(path_2, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //создание каталога
        private void CreateCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form2.ShowDialog();
            try
            {
                if (listView1.Focused == true)
                {

                    dirInfo = new DirectoryInfo(textBox_Path_1.Text);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }
                    dirInfo.CreateSubdirectory(create_new_catalog_or_file);
                    listView1.Items.Clear();
                    GetDirect(path, true);
                }
                else if (listView2.Focused == true)
                {
                    dirInfo = new DirectoryInfo(textBox_Path_2.Text);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }
                    dirInfo.CreateSubdirectory(create_new_catalog_or_file);
                    listView2.Items.Clear();
                    GetDirect(path_2, false);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddText(string text)
        {
            create_new_catalog_or_file = text;
        }
        //копировать
        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.Focused)
            {
                bufer = textBox_Path_1.Text;
            }
            else if(listView2.Focused)
            {
                bufer = textBox_Path_2.Text;
            }
        }

        //вставить
        private void paste_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (listView1.Focused == true)
                {

                    if (Path.GetExtension(path) == String.Empty)
                    {
                        dirInfo = new DirectoryInfo(textBox_Path_2.Text + "\\" + "New Directory");
                        if (dirInfo.Exists)
                            dirInfo.Delete(true);
                        new DirectoryInfo(bufer).MoveTo(textBox_Path_2.Text + "\\" + "New Directory");

                    }
                    else
                    {

                    }
                    listView1.Items.Clear();
                    GetDirect(path, true);
                }
                else if (listView2.Focused == true)
                {
                    if (Path.GetExtension(path_2) == String.Empty)
                    {
                        DirectoryInfo destDir = new DirectoryInfo(textBox_Path_2.Text + "\\" + "New Directory");
                        if (destDir.Exists)
                            destDir.Delete(true);
                        new DirectoryInfo(bufer).MoveTo(textBox_Path_2.Text + "\\" + "New Directory");
                    }
                    else
                    {

                    }
                    listView2.Items.Clear();
                    GetDirect(path_2, false);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //получить директорию
        public void GetDirect(string path,bool first_or_second)
        {
            if (first_or_second == true)
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    listView1.Items.Add(directory, 0);
                }

                foreach (var files in Directory.GetFiles(path))
                {
                    listView1.Items.Add(files, 1);
                    //listView2.Columns[1].
                }
            }
            else
            {
                foreach (var directory in Directory.GetDirectories(path))
                {
                    listView2.Items.Add(directory, 0);
                }

                foreach (var files in Directory.GetFiles(path))
                {
                    listView2.Items.Add(files, 1);
                    //listView2.Columns[1].
                }
            }
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var items = new List<ListViewItem>();
            items.Add((ListViewItem)e.Item);
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
            listView1.DoDragDrop(items, DragDropEffects.Move);
        }

        private void listView2_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                foreach (ListViewItem lvi in items)
                {
                    lvi.ListView.Items.Remove(lvi);
                    listView2.Items.Add(lvi);
                }
            }
        }
    }
}
