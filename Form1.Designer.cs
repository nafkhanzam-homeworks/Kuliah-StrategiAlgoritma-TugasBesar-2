namespace Tubes_Stima_2
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.goBtn = new System.Windows.Forms.Button();
            this.dayTxtBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.input = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.listKotaTxtBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.petaHubunganBtn = new System.Windows.Forms.Button();
            this.listKotaBtn = new System.Windows.Forms.Button();
            this.petaTxtBox = new System.Windows.Forms.RichTextBox();
            this.openFileListKotaDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFilePetaDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // goBtn
            // 
            this.goBtn.Font = new System.Drawing.Font("Microsoft Uighur", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.Location = new System.Drawing.Point(476, 655);
            this.goBtn.Margin = new System.Windows.Forms.Padding(2);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(190, 91);
            this.goBtn.TabIndex = 3;
            this.goBtn.Text = "GO";
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dayTxtBox
            // 
            this.dayTxtBox.Location = new System.Drawing.Point(123, 166);
            this.dayTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.dayTxtBox.Name = "dayTxtBox";
            this.dayTxtBox.Size = new System.Drawing.Size(543, 26);
            this.dayTxtBox.TabIndex = 4;
            this.dayTxtBox.Text = "0";
            this.dayTxtBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(679, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 622);
            this.panel1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1486, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // input
            // 
            this.input.AutoSize = true;
            this.input.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(17, 168);
            this.input.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(95, 16);
            this.input.TabIndex = 8;
            this.input.Text = "Masukkan Hari";
            this.input.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(93, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 64);
            this.label1.TabIndex = 9;
            this.label1.Text = "ANAROC";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.Gainsboro;
            // 
            // listKotaTxtBox
            // 
            this.listKotaTxtBox.Location = new System.Drawing.Point(123, 210);
            this.listKotaTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.listKotaTxtBox.Name = "listKotaTxtBox";
            this.listKotaTxtBox.Size = new System.Drawing.Size(543, 188);
            this.listKotaTxtBox.TabIndex = 10;
            this.listKotaTxtBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(17, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Masukkan Graf";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(18, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "atau load file:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // petaHubunganBtn
            // 
            this.petaHubunganBtn.Font = new System.Drawing.Font("Microsoft Uighur", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petaHubunganBtn.Location = new System.Drawing.Point(20, 413);
            this.petaHubunganBtn.Margin = new System.Windows.Forms.Padding(2);
            this.petaHubunganBtn.Name = "petaHubunganBtn";
            this.petaHubunganBtn.Size = new System.Drawing.Size(80, 55);
            this.petaHubunganBtn.TabIndex = 13;
            this.petaHubunganBtn.Text = "Peta hubungan";
            this.petaHubunganBtn.UseVisualStyleBackColor = false;
            this.petaHubunganBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // listKotaBtn
            // 
            this.listKotaBtn.Font = new System.Drawing.Font("Microsoft Uighur", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKotaBtn.Location = new System.Drawing.Point(20, 276);
            this.listKotaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.listKotaBtn.Name = "listKotaBtn";
            this.listKotaBtn.Size = new System.Drawing.Size(80, 30);
            this.listKotaBtn.TabIndex = 14;
            this.listKotaBtn.Text = "List Kota";
            this.listKotaBtn.UseVisualStyleBackColor = false;
            this.listKotaBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // petaTxtBox
            // 
            this.petaTxtBox.Location = new System.Drawing.Point(123, 413);
            this.petaTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.petaTxtBox.Name = "petaTxtBox";
            this.petaTxtBox.Size = new System.Drawing.Size(543, 188);
            this.petaTxtBox.TabIndex = 15;
            this.petaTxtBox.Text = "";
            this.petaTxtBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // openFileListKotaDialog
            // 
            this.openFileListKotaDialog.FileName = "openFileListKotaDialog";
            this.openFileListKotaDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFilePetaDialog
            // 
            this.openFilePetaDialog.FileName = "openFilePetaDialog";
            this.openFilePetaDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFilePetaDialog_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 757);
            this.Controls.Add(this.petaTxtBox);
            this.Controls.Add(this.listKotaBtn);
            this.Controls.Add(this.petaHubunganBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listKotaTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dayTxtBox);
            this.Controls.Add(this.goBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.RichTextBox dayTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox listKotaTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button petaHubunganBtn;
        private System.Windows.Forms.Button listKotaBtn;
        private System.Windows.Forms.RichTextBox petaTxtBox;
        private System.Windows.Forms.OpenFileDialog openFileListKotaDialog;
        private System.Windows.Forms.OpenFileDialog openFilePetaDialog;
    }
}

