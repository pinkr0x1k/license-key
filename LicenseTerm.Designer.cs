namespace LicenseKey
{
    partial class LicenseTerm
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.licensetype = new System.Windows.Forms.Label();
            this.pkey = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.cbLicenseType = new System.Windows.Forms.ComboBox();
            this.end = new System.Windows.Forms.Label();
            this.productKey = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.cname = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.companyName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.sFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // licensetype
            // 
            this.licensetype.AutoSize = true;
            this.licensetype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensetype.Location = new System.Drawing.Point(37, 295);
            this.licensetype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.licensetype.Name = "licensetype";
            this.licensetype.Size = new System.Drawing.Size(127, 20);
            this.licensetype.TabIndex = 8;
            this.licensetype.Text = "License Type:";
            // 
            // pkey
            // 
            this.pkey.AutoSize = true;
            this.pkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkey.Location = new System.Drawing.Point(52, 261);
            this.pkey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pkey.Name = "pkey";
            this.pkey.Size = new System.Drawing.Size(117, 20);
            this.pkey.TabIndex = 6;
            this.pkey.Text = "Product Key:";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(71, 78);
            this.start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(102, 20);
            this.start.TabIndex = 5;
            this.start.Text = "Start Date:";
            // 
            // cbLicenseType
            // 
            this.cbLicenseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLicenseType.FormattingEnabled = true;
            this.cbLicenseType.Location = new System.Drawing.Point(201, 292);
            this.cbLicenseType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbLicenseType.Name = "cbLicenseType";
            this.cbLicenseType.Size = new System.Drawing.Size(356, 24);
            this.cbLicenseType.TabIndex = 13;
            this.cbLicenseType.SelectedIndexChanged += new System.EventHandler(this.cboLicenseType_SelectedIndexChanged);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(77, 116);
            this.end.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(93, 20);
            this.end.TabIndex = 14;
            this.end.Text = "End Date:";
            // 
            // productKey
            // 
            this.productKey.Location = new System.Drawing.Point(201, 256);
            this.productKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.productKey.Name = "productKey";
            this.productKey.Size = new System.Drawing.Size(484, 22);
            this.productKey.TabIndex = 15;
            this.productKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(201, 78);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(265, 22);
            this.startDate.TabIndex = 16;
            this.startDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(201, 116);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(265, 22);
            this.endDate.TabIndex = 17;
            this.endDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.Location = new System.Drawing.Point(16, 153);
            this.cname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(146, 20);
            this.cname.TabIndex = 18;
            this.cname.Text = "Company Name:";
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.Location = new System.Drawing.Point(32, 223);
            this.pname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(134, 20);
            this.pname.TabIndex = 20;
            this.pname.Text = "Product Name:";
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(201, 222);
            this.productName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(484, 22);
            this.productName.TabIndex = 21;
            this.productName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(201, 326);
            this.Generate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(192, 36);
            this.Generate.TabIndex = 22;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(557, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Exit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(340, 407);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(162, 25);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ceng.deu.edu.tr";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(201, 153);
            this.companyName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(356, 22);
            this.companyName.TabIndex = 19;
            this.companyName.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(41, 186);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(117, 25);
            this.Save.TabIndex = 25;
            this.Save.Text = "Save File";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // sFile
            // 
            this.sFile.Location = new System.Drawing.Point(201, 187);
            this.sFile.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sFile.Name = "sFile";
            this.sFile.Size = new System.Drawing.Size(265, 22);
            this.sFile.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = ":";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Hata Kelime";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hata Mesaj";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hata Tarihi";
            this.columnHeader3.Width = 162;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(748, 78);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(384, 283);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // LicenseTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1180, 441);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sFile);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.productKey);
            this.Controls.Add(this.end);
            this.Controls.Add(this.cbLicenseType);
            this.Controls.Add(this.licensetype);
            this.Controls.Add(this.pkey);
            this.Controls.Add(this.start);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LicenseTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LicenseTerm";
            this.Load += new System.EventHandler(this.LicenseTerm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label licensetype;
        private System.Windows.Forms.Label pkey;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.ComboBox cbLicenseType;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.TextBox productKey;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label cname;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox sFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}