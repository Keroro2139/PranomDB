namespace Pranom
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Clockout = new System.Windows.Forms.Button();
            this.Lsurname = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lempcode = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.Clockin = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GridClokin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClokin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(28, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 365);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.Clockout);
            this.tabPage2.Controls.Add(this.Lsurname);
            this.tabPage2.Controls.Add(this.Lname);
            this.tabPage2.Controls.Add(this.textSurname);
            this.tabPage2.Controls.Add(this.textName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Lempcode);
            this.tabPage2.Controls.Add(this.textCode);
            this.tabPage2.Controls.Add(this.Clockin);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(855, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clock In";
            // 
            // Clockout
            // 
            this.Clockout.BackColor = System.Drawing.Color.IndianRed;
            this.Clockout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clockout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clockout.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clockout.ForeColor = System.Drawing.Color.White;
            this.Clockout.Location = new System.Drawing.Point(458, 229);
            this.Clockout.Name = "Clockout";
            this.Clockout.Size = new System.Drawing.Size(87, 35);
            this.Clockout.TabIndex = 36;
            this.Clockout.Text = "Clock Out";
            this.Clockout.UseVisualStyleBackColor = false;
            this.Clockout.Click += new System.EventHandler(this.Clockout_Click);
            // 
            // Lsurname
            // 
            this.Lsurname.AutoSize = true;
            this.Lsurname.ForeColor = System.Drawing.Color.White;
            this.Lsurname.Location = new System.Drawing.Point(349, 163);
            this.Lsurname.Name = "Lsurname";
            this.Lsurname.Size = new System.Drawing.Size(56, 16);
            this.Lsurname.TabIndex = 35;
            this.Lsurname.Text = "Surname";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.ForeColor = System.Drawing.Color.White;
            this.Lname.Location = new System.Drawing.Point(364, 122);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(41, 16);
            this.Lname.TabIndex = 34;
            this.Lname.Text = "Name";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(411, 160);
            this.textSurname.MaxLength = 3000;
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(100, 23);
            this.textSurname.TabIndex = 33;
            this.textSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSurname_KeyDown);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(411, 119);
            this.textName.MaxLength = 3000;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 32;
            this.textName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textName_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(517, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "*";
            // 
            // Lempcode
            // 
            this.Lempcode.AutoSize = true;
            this.Lempcode.ForeColor = System.Drawing.Color.White;
            this.Lempcode.Location = new System.Drawing.Point(343, 81);
            this.Lempcode.Name = "Lempcode";
            this.Lempcode.Size = new System.Drawing.Size(62, 16);
            this.Lempcode.TabIndex = 30;
            this.Lempcode.Text = "Emp code";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(411, 78);
            this.textCode.MaxLength = 3;
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(100, 23);
            this.textCode.TabIndex = 29;
            this.textCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textCode_KeyDown);
            // 
            // Clockin
            // 
            this.Clockin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(97)))));
            this.Clockin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clockin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clockin.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clockin.ForeColor = System.Drawing.Color.White;
            this.Clockin.Location = new System.Drawing.Point(338, 229);
            this.Clockin.Name = "Clockin";
            this.Clockin.Size = new System.Drawing.Size(87, 35);
            this.Clockin.TabIndex = 28;
            this.Clockin.Text = "Clock In";
            this.Clockin.UseVisualStyleBackColor = false;
            this.Clockin.Click += new System.EventHandler(this.Clockin_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.Search);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textSearch);
            this.tabPage1.Controls.Add(this.GridClokin);
            this.tabPage1.Controls.Add(this.Refresh);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(855, 336);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "List";
            // 
            // GridClokin
            // 
            this.GridClokin.AllowUserToAddRows = false;
            this.GridClokin.AllowUserToDeleteRows = false;
            this.GridClokin.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.GridClokin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridClokin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClokin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7});
            this.GridClokin.Location = new System.Drawing.Point(19, 63);
            this.GridClokin.Name = "GridClokin";
            this.GridClokin.ReadOnly = true;
            this.GridClokin.Size = new System.Drawing.Size(830, 267);
            this.GridClokin.TabIndex = 39;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Emp_Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Emp_Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Emp_Surname";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ClockIn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ClockOut";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 140;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Amount(Hour)";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 110;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(97)))));
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(759, 29);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(73, 28);
            this.Refresh.TabIndex = 40;
            this.Refresh.Text = "refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Hebrew", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(804, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 14);
            this.label1.TabIndex = 31;
            this.label1.Text = "Pranom Book Store";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label33.Font = new System.Drawing.Font("Myriad Hebrew", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(69, 34);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(159, 36);
            this.label33.TabIndex = 28;
            this.label33.Text = "WORK TIME";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Pranom.Properties.Resources.Untitled_52;
            this.pictureBox2.Location = new System.Drawing.Point(818, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pranom.Properties.Resources.aa;
            this.pictureBox1.Location = new System.Drawing.Point(28, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Myriad Hebrew", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(87, 29);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(109, 25);
            this.textSearch.TabIndex = 41;
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "CODE :";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(97)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Myriad Hebrew", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(213, 27);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(73, 28);
            this.Search.TabIndex = 43;
            this.Search.Text = "search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(917, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pranom Book Store - Work Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form8_FormClosing);
            this.Load += new System.EventHandler(this.Form8_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClokin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label Lsurname;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lempcode;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Button Clockin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView GridClokin;
        private System.Windows.Forms.Button Clockout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSearch;
    }
}