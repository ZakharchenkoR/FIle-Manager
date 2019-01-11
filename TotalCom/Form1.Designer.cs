namespace TotalCom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_return_to_last_direct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.create_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.file_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.catalog_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.del_con_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copy_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paste_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Path_2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox_Path_1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateCatalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copy_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paste_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_shrift_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_first_catagog_fon_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.new_second_catalog_fon_ФонВнутриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fone_catalog1_ФонПервогоКаталогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fone_catagol2_ФонВторогоКаталогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 770);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_return_to_last_direct);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Controls.Add(this.textBox_Path_2);
            this.groupBox3.Location = new System.Drawing.Point(661, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 740);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Каталог №2";
            // 
            // button_return_to_last_direct
            // 
            this.button_return_to_last_direct.Location = new System.Drawing.Point(17, 23);
            this.button_return_to_last_direct.Name = "button_return_to_last_direct";
            this.button_return_to_last_direct.Size = new System.Drawing.Size(48, 23);
            this.button_return_to_last_direct.TabIndex = 4;
            this.button_return_to_last_direct.Text = "<<";
            this.button_return_to_last_direct.UseVisualStyleBackColor = true;
            this.button_return_to_last_direct.Click += new System.EventHandler(this.button_return_to_last_direct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path:";
            // 
            // listView2
            // 
            this.listView2.AllowDrop = true;
            this.listView2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView2.ContextMenuStrip = this.contextMenuStrip1;
            this.listView2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.Location = new System.Drawing.Point(17, 54);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(574, 681);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView2_DragDrop);
            this.listView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView2_DragEnter);
            this.listView2.DragOver += new System.Windows.Forms.DragEventHandler(this.listView2_DragOver);
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create_ToolStripMenuItem1,
            this.del_con_ToolStripMenuItem,
            this.copy_ToolStripMenuItem1,
            this.paste_ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 92);
            // 
            // create_ToolStripMenuItem1
            // 
            this.create_ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_ToolStripMenuItem1,
            this.catalog_ToolStripMenuItem});
            this.create_ToolStripMenuItem1.Name = "create_ToolStripMenuItem1";
            this.create_ToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.create_ToolStripMenuItem1.Text = "Создать";
            // 
            // file_ToolStripMenuItem1
            // 
            this.file_ToolStripMenuItem1.Name = "file_ToolStripMenuItem1";
            this.file_ToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.file_ToolStripMenuItem1.Text = "Файл";
            // 
            // catalog_ToolStripMenuItem
            // 
            this.catalog_ToolStripMenuItem.Name = "catalog_ToolStripMenuItem";
            this.catalog_ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.catalog_ToolStripMenuItem.Text = "Каталог";
            // 
            // del_con_ToolStripMenuItem
            // 
            this.del_con_ToolStripMenuItem.Name = "del_con_ToolStripMenuItem";
            this.del_con_ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.del_con_ToolStripMenuItem.Text = "Удалить";
            // 
            // copy_ToolStripMenuItem1
            // 
            this.copy_ToolStripMenuItem1.Name = "copy_ToolStripMenuItem1";
            this.copy_ToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.copy_ToolStripMenuItem1.Text = "Копировать";
            // 
            // paste_ToolStripMenuItem1
            // 
            this.paste_ToolStripMenuItem1.Name = "paste_ToolStripMenuItem1";
            this.paste_ToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.paste_ToolStripMenuItem1.Text = "Вставить";
            // 
            // textBox_Path_2
            // 
            this.textBox_Path_2.Location = new System.Drawing.Point(135, 25);
            this.textBox_Path_2.Name = "textBox_Path_2";
            this.textBox_Path_2.ReadOnly = true;
            this.textBox_Path_2.Size = new System.Drawing.Size(456, 20);
            this.textBox_Path_2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.textBox_Path_1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 740);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Каталог №1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Path:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(17, 54);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(574, 681);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            this.listView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
            // 
            // textBox_Path_1
            // 
            this.textBox_Path_1.Location = new System.Drawing.Point(133, 23);
            this.textBox_Path_1.Name = "textBox_Path_1";
            this.textBox_Path_1.ReadOnly = true;
            this.textBox_Path_1.Size = new System.Drawing.Size(458, 20);
            this.textBox_Path_1.TabIndex = 1;
            this.textBox_Path_1.TextChanged += new System.EventHandler(this.textBox_Path_1_TextChanged);
            this.textBox_Path_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_Path_1_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder ORANGE .ico");
            this.imageList1.Images.SetKeyName(1, "File Text.ico");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.copy_ToolStripMenuItem,
            this.paste_ToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateFileToolStripMenuItem1,
            this.CreateCatalogToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // CreateFileToolStripMenuItem1
            // 
            this.CreateFileToolStripMenuItem1.Name = "CreateFileToolStripMenuItem1";
            this.CreateFileToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.CreateFileToolStripMenuItem1.Text = "Файл";
            this.CreateFileToolStripMenuItem1.Click += new System.EventHandler(this.CreateFileToolStripMenuItem1_Click);
            // 
            // CreateCatalogToolStripMenuItem
            // 
            this.CreateCatalogToolStripMenuItem.Name = "CreateCatalogToolStripMenuItem";
            this.CreateCatalogToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.CreateCatalogToolStripMenuItem.Text = "Каталог";
            this.CreateCatalogToolStripMenuItem.Click += new System.EventHandler(this.CreateCatalogToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // copy_ToolStripMenuItem
            // 
            this.copy_ToolStripMenuItem.Name = "copy_ToolStripMenuItem";
            this.copy_ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.copy_ToolStripMenuItem.Text = "Копировать";
            this.copy_ToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // paste_ToolStripMenuItem
            // 
            this.paste_ToolStripMenuItem.Name = "paste_ToolStripMenuItem";
            this.paste_ToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.paste_ToolStripMenuItem.Text = "Вставить";
            this.paste_ToolStripMenuItem.Click += new System.EventHandler(this.paste_ToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_shrift_ToolStripMenuItem,
            this.new_first_catagog_fon_ToolStripMenuItem,
            this.new_second_catalog_fon_ФонВнутриToolStripMenuItem,
            this.fone_catalog1_ФонПервогоКаталогоToolStripMenuItem,
            this.fone_catagol2_ФонВторогоКаталогаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // new_shrift_ToolStripMenuItem
            // 
            this.new_shrift_ToolStripMenuItem.Name = "new_shrift_ToolStripMenuItem";
            this.new_shrift_ToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.new_shrift_ToolStripMenuItem.Text = "Изменить шрифт";
            this.new_shrift_ToolStripMenuItem.Click += new System.EventHandler(this.new_shrift_ToolStripMenuItem_Click);
            // 
            // new_first_catagog_fon_ToolStripMenuItem
            // 
            this.new_first_catagog_fon_ToolStripMenuItem.Name = "new_first_catagog_fon_ToolStripMenuItem";
            this.new_first_catagog_fon_ToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.new_first_catagog_fon_ToolStripMenuItem.Text = "Изменить внешний фон";
            this.new_first_catagog_fon_ToolStripMenuItem.Click += new System.EventHandler(this.new_first_catagog_fon_ToolStripMenuItem_Click);
            // 
            // new_second_catalog_fon_ФонВнутриToolStripMenuItem
            // 
            this.new_second_catalog_fon_ФонВнутриToolStripMenuItem.Name = "new_second_catalog_fon_ФонВнутриToolStripMenuItem";
            this.new_second_catalog_fon_ФонВнутриToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.new_second_catalog_fon_ФонВнутриToolStripMenuItem.Text = "Изменить фон внутри";
            this.new_second_catalog_fon_ФонВнутриToolStripMenuItem.Click += new System.EventHandler(this.new_second_catalog_fon_ФонВнутриToolStripMenuItem_Click);
            // 
            // fone_catalog1_ФонПервогоКаталогоToolStripMenuItem
            // 
            this.fone_catalog1_ФонПервогоКаталогоToolStripMenuItem.Name = "fone_catalog1_ФонПервогоКаталогоToolStripMenuItem";
            this.fone_catalog1_ФонПервогоКаталогоToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.fone_catalog1_ФонПервогоКаталогоToolStripMenuItem.Text = "Изменить фон первого каталого";
            this.fone_catalog1_ФонПервогоКаталогоToolStripMenuItem.Click += new System.EventHandler(this.fone_catalog1_ФонПервогоКаталогоToolStripMenuItem_Click);
            // 
            // fone_catagol2_ФонВторогоКаталогаToolStripMenuItem
            // 
            this.fone_catagol2_ФонВторогоКаталогаToolStripMenuItem.Name = "fone_catagol2_ФонВторогоКаталогаToolStripMenuItem";
            this.fone_catagol2_ФонВторогоКаталогаToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.fone_catagol2_ФонВторогоКаталогаToolStripMenuItem.Text = "Изменить фон второго каталога";
            this.fone_catagol2_ФонВторогоКаталогаToolStripMenuItem.Click += new System.EventHandler(this.fone_catagol2_ФонВторогоКаталогаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 807);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Path_1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_return_to_last_direct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox textBox_Path_2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copy_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paste_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem create_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem del_con_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copy_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paste_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new_shrift_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new_first_catagog_fon_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem new_second_catalog_fon_ФонВнутриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fone_catalog1_ФонПервогоКаталогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fone_catagol2_ФонВторогоКаталогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CreateCatalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem catalog_ToolStripMenuItem;
    }
}

