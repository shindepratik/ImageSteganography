namespace Steganography
{
    partial class FrmSteganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSteganography));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DeLoadImage_tbx = new System.Windows.Forms.TextBox();
            this.DeSaveFile_tbx = new System.Windows.Forms.TextBox();
            this.DeSaveFileBrowse_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DeLoadImageBrowse_btn = new System.Windows.Forms.Button();
            this.Decrypt_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnFileBrowse_btn = new System.Windows.Forms.Button();
            this.EnImageBrowse_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EnFile_tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnImage_tbx = new System.Windows.Forms.TextBox();
            this.Encrypt_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ImageSize_lbl = new System.Windows.Forms.Label();
            this.ImageHeight_lbl = new System.Windows.Forms.Label();
            this.ImageWidth_lbl = new System.Windows.Forms.Label();
            this.CanSave_lbl = new System.Windows.Forms.Label();
            this.ByteCapacity_lbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DeLoadImage_tbx);
            this.groupBox1.Controls.Add(this.DeSaveFile_tbx);
            this.groupBox1.Controls.Add(this.DeSaveFileBrowse_btn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DeLoadImageBrowse_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select Encrypted Image:";
            // 
            // DeLoadImage_tbx
            // 
            this.DeLoadImage_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeLoadImage_tbx.BackColor = System.Drawing.Color.Black;
            this.DeLoadImage_tbx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeLoadImage_tbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeLoadImage_tbx.Location = new System.Drawing.Point(18, 44);
            this.DeLoadImage_tbx.Name = "DeLoadImage_tbx";
            this.DeLoadImage_tbx.Size = new System.Drawing.Size(305, 26);
            this.DeLoadImage_tbx.TabIndex = 0;
            this.DeLoadImage_tbx.TextChanged += new System.EventHandler(this.DeLoadImage_tbx_TextChanged);
            // 
            // DeSaveFile_tbx
            // 
            this.DeSaveFile_tbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeSaveFile_tbx.BackColor = System.Drawing.Color.Black;
            this.DeSaveFile_tbx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeSaveFile_tbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeSaveFile_tbx.Location = new System.Drawing.Point(21, 184);
            this.DeSaveFile_tbx.Name = "DeSaveFile_tbx";
            this.DeSaveFile_tbx.Size = new System.Drawing.Size(305, 26);
            this.DeSaveFile_tbx.TabIndex = 2;
            this.DeSaveFile_tbx.TextChanged += new System.EventHandler(this.DeSaveFile_tbx_TextChanged);
            // 
            // DeSaveFileBrowse_btn
            // 
            this.DeSaveFileBrowse_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeSaveFileBrowse_btn.BackColor = System.Drawing.Color.Transparent;
            this.DeSaveFileBrowse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeSaveFileBrowse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeSaveFileBrowse_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeSaveFileBrowse_btn.ForeColor = System.Drawing.Color.White;
            this.DeSaveFileBrowse_btn.Location = new System.Drawing.Point(99, 225);
            this.DeSaveFileBrowse_btn.Name = "DeSaveFileBrowse_btn";
            this.DeSaveFileBrowse_btn.Size = new System.Drawing.Size(118, 45);
            this.DeSaveFileBrowse_btn.TabIndex = 3;
            this.DeSaveFileBrowse_btn.Text = "Browse";
            this.DeSaveFileBrowse_btn.UseVisualStyleBackColor = false;
            this.DeSaveFileBrowse_btn.Click += new System.EventHandler(this.DeSaveFileBrowse_btn_Click);
            this.DeSaveFileBrowse_btn.MouseEnter += new System.EventHandler(this.DeSaveFileBrowse_btn_MouseEnter);
            this.DeSaveFileBrowse_btn.MouseLeave += new System.EventHandler(this.DeSaveFileBrowse_btn_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(17, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Save file to:";
            // 
            // DeLoadImageBrowse_btn
            // 
            this.DeLoadImageBrowse_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeLoadImageBrowse_btn.BackColor = System.Drawing.Color.Transparent;
            this.DeLoadImageBrowse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeLoadImageBrowse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeLoadImageBrowse_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeLoadImageBrowse_btn.ForeColor = System.Drawing.Color.White;
            this.DeLoadImageBrowse_btn.Location = new System.Drawing.Point(99, 85);
            this.DeLoadImageBrowse_btn.Name = "DeLoadImageBrowse_btn";
            this.DeLoadImageBrowse_btn.Size = new System.Drawing.Size(118, 45);
            this.DeLoadImageBrowse_btn.TabIndex = 1;
            this.DeLoadImageBrowse_btn.Text = "Browse";
            this.DeLoadImageBrowse_btn.UseVisualStyleBackColor = false;
            this.DeLoadImageBrowse_btn.Click += new System.EventHandler(this.DeLoadImageBrowse_btn_Click);
            this.DeLoadImageBrowse_btn.MouseEnter += new System.EventHandler(this.DeLoadImageBrowse_btn_MouseEnter);
            this.DeLoadImageBrowse_btn.MouseLeave += new System.EventHandler(this.DeLoadImageBrowse_btn_MouseLeave);
            // 
            // Decrypt_btn
            // 
            this.Decrypt_btn.BackColor = System.Drawing.Color.Transparent;
            this.Decrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt_btn.ForeColor = System.Drawing.Color.White;
            this.Decrypt_btn.Location = new System.Drawing.Point(85, 338);
            this.Decrypt_btn.Name = "Decrypt_btn";
            this.Decrypt_btn.Size = new System.Drawing.Size(167, 48);
            this.Decrypt_btn.TabIndex = 3;
            this.Decrypt_btn.Text = "Decrypt";
            this.Decrypt_btn.UseVisualStyleBackColor = false;
            this.Decrypt_btn.Click += new System.EventHandler(this.Decrypt_btn_Click);
            this.Decrypt_btn.MouseEnter += new System.EventHandler(this.Decrypt_btn_MouseEnter);
            this.Decrypt_btn.MouseLeave += new System.EventHandler(this.Decrypt_btn_MouseLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.EnFileBrowse_btn);
            this.groupBox2.Controls.Add(this.EnImageBrowse_btn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.EnFile_tbx);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EnImage_tbx);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(7, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 305);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // EnFileBrowse_btn
            // 
            this.EnFileBrowse_btn.BackColor = System.Drawing.Color.Transparent;
            this.EnFileBrowse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnFileBrowse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnFileBrowse_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnFileBrowse_btn.ForeColor = System.Drawing.Color.White;
            this.EnFileBrowse_btn.Location = new System.Drawing.Point(99, 225);
            this.EnFileBrowse_btn.Name = "EnFileBrowse_btn";
            this.EnFileBrowse_btn.Size = new System.Drawing.Size(118, 45);
            this.EnFileBrowse_btn.TabIndex = 3;
            this.EnFileBrowse_btn.Text = "Browse";
            this.EnFileBrowse_btn.UseVisualStyleBackColor = false;
            this.EnFileBrowse_btn.Click += new System.EventHandler(this.EnFileBrowse_btn_Click);
            this.EnFileBrowse_btn.MouseEnter += new System.EventHandler(this.EnFileBrowse_btn_MouseEnter);
            this.EnFileBrowse_btn.MouseLeave += new System.EventHandler(this.EnFileBrowse_btn_MouseLeave);
            // 
            // EnImageBrowse_btn
            // 
            this.EnImageBrowse_btn.BackColor = System.Drawing.Color.Transparent;
            this.EnImageBrowse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnImageBrowse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnImageBrowse_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnImageBrowse_btn.ForeColor = System.Drawing.Color.White;
            this.EnImageBrowse_btn.Location = new System.Drawing.Point(99, 85);
            this.EnImageBrowse_btn.Name = "EnImageBrowse_btn";
            this.EnImageBrowse_btn.Size = new System.Drawing.Size(118, 45);
            this.EnImageBrowse_btn.TabIndex = 1;
            this.EnImageBrowse_btn.Text = "Browse";
            this.EnImageBrowse_btn.UseVisualStyleBackColor = false;
            this.EnImageBrowse_btn.Click += new System.EventHandler(this.EnImageBrowse_btn_Click);
            this.EnImageBrowse_btn.MouseEnter += new System.EventHandler(this.EnImageBrowse_btn_MouseEnter);
            this.EnImageBrowse_btn.MouseLeave += new System.EventHandler(this.EnImageBrowse_btn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Load file:";
            // 
            // EnFile_tbx
            // 
            this.EnFile_tbx.BackColor = System.Drawing.Color.Black;
            this.EnFile_tbx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnFile_tbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EnFile_tbx.Location = new System.Drawing.Point(21, 184);
            this.EnFile_tbx.Name = "EnFile_tbx";
            this.EnFile_tbx.Size = new System.Drawing.Size(305, 26);
            this.EnFile_tbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Carrier Image:";
            // 
            // EnImage_tbx
            // 
            this.EnImage_tbx.BackColor = System.Drawing.Color.Black;
            this.EnImage_tbx.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnImage_tbx.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EnImage_tbx.Location = new System.Drawing.Point(18, 44);
            this.EnImage_tbx.Name = "EnImage_tbx";
            this.EnImage_tbx.Size = new System.Drawing.Size(305, 26);
            this.EnImage_tbx.TabIndex = 0;
            // 
            // Encrypt_btn
            // 
            this.Encrypt_btn.BackColor = System.Drawing.Color.Transparent;
            this.Encrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt_btn.ForeColor = System.Drawing.Color.White;
            this.Encrypt_btn.Location = new System.Drawing.Point(85, 338);
            this.Encrypt_btn.Name = "Encrypt_btn";
            this.Encrypt_btn.Size = new System.Drawing.Size(167, 48);
            this.Encrypt_btn.TabIndex = 3;
            this.Encrypt_btn.Text = "Encrypt";
            this.Encrypt_btn.UseVisualStyleBackColor = false;
            this.Encrypt_btn.Click += new System.EventHandler(this.Encrypt_btn_Click);
            this.Encrypt_btn.MouseEnter += new System.EventHandler(this.Encrypt_btn_MouseEnter);
            this.Encrypt_btn.MouseLeave += new System.EventHandler(this.Encrypt_btn_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp|All files(*.*)|*.*";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "All files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.Filter = "Bitmap Files (*.bmp)|*.bmp";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 436);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.Encrypt_btn);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypt ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.Decrypt_btn);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decrypt ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(555, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 705);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(216, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pratik, Amrita, Rohan [BE-B]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(5, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Image Preview :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(920, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 18);
            this.label11.TabIndex = 7;
            this.label11.Text = "x";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            this.label11.MouseEnter += new System.EventHandler(this.label11_MouseEnter);
            this.label11.MouseLeave += new System.EventHandler(this.label11_MouseLeave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(898, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "_";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            this.label12.MouseEnter += new System.EventHandler(this.label12_MouseEnter);
            this.label12.MouseLeave += new System.EventHandler(this.label12_MouseLeave);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.IndianRed;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(936, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-172, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Size : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-172, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Height : ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-172, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Width : ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-172, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Can save : ";
            // 
            // ImageSize_lbl
            // 
            this.ImageSize_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSize_lbl.AutoSize = true;
            this.ImageSize_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageSize_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ImageSize_lbl.Location = new System.Drawing.Point(-98, 52);
            this.ImageSize_lbl.Name = "ImageSize_lbl";
            this.ImageSize_lbl.Size = new System.Drawing.Size(40, 20);
            this.ImageSize_lbl.TabIndex = 1;
            this.ImageSize_lbl.Text = "none";
            this.ImageSize_lbl.Click += new System.EventHandler(this.ImageSize_lbl_Click);
            // 
            // ImageHeight_lbl
            // 
            this.ImageHeight_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageHeight_lbl.AutoSize = true;
            this.ImageHeight_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageHeight_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ImageHeight_lbl.Location = new System.Drawing.Point(-98, 77);
            this.ImageHeight_lbl.Name = "ImageHeight_lbl";
            this.ImageHeight_lbl.Size = new System.Drawing.Size(40, 20);
            this.ImageHeight_lbl.TabIndex = 1;
            this.ImageHeight_lbl.Text = "none";
            // 
            // ImageWidth_lbl
            // 
            this.ImageWidth_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageWidth_lbl.AutoSize = true;
            this.ImageWidth_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageWidth_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ImageWidth_lbl.Location = new System.Drawing.Point(-98, 102);
            this.ImageWidth_lbl.Name = "ImageWidth_lbl";
            this.ImageWidth_lbl.Size = new System.Drawing.Size(40, 20);
            this.ImageWidth_lbl.TabIndex = 1;
            this.ImageWidth_lbl.Text = "none";
            // 
            // CanSave_lbl
            // 
            this.CanSave_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CanSave_lbl.AutoSize = true;
            this.CanSave_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanSave_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CanSave_lbl.Location = new System.Drawing.Point(-98, 127);
            this.CanSave_lbl.Name = "CanSave_lbl";
            this.CanSave_lbl.Size = new System.Drawing.Size(40, 20);
            this.CanSave_lbl.TabIndex = 1;
            this.CanSave_lbl.Text = "none";
            // 
            // ByteCapacity_lbl
            // 
            this.ByteCapacity_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ByteCapacity_lbl.AutoSize = true;
            this.ByteCapacity_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByteCapacity_lbl.Location = new System.Drawing.Point(-102, 77);
            this.ByteCapacity_lbl.Name = "ByteCapacity_lbl";
            this.ByteCapacity_lbl.Size = new System.Drawing.Size(0, 20);
            this.ByteCapacity_lbl.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.ByteCapacity_lbl);
            this.groupBox3.Controls.Add(this.CanSave_lbl);
            this.groupBox3.Controls.Add(this.ImageWidth_lbl);
            this.groupBox3.Controls.Add(this.ImageHeight_lbl);
            this.groupBox3.Controls.Add(this.ImageSize_lbl);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(349, 649);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(10, 10);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image information";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // FrmSteganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(936, 705);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSteganography";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCrypt+ V1.0";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button EnImageBrowse_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnImage_tbx;
        private System.Windows.Forms.Button EnFileBrowse_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnFile_tbx;
        private System.Windows.Forms.Button Encrypt_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Decrypt_btn;
        private System.Windows.Forms.TextBox DeLoadImage_tbx;
        private System.Windows.Forms.TextBox DeSaveFile_tbx;
        private System.Windows.Forms.Button DeSaveFileBrowse_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeLoadImageBrowse_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ByteCapacity_lbl;
        private System.Windows.Forms.Label CanSave_lbl;
        private System.Windows.Forms.Label ImageWidth_lbl;
        private System.Windows.Forms.Label ImageHeight_lbl;
        private System.Windows.Forms.Label ImageSize_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

