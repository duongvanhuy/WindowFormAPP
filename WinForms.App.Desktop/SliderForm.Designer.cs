namespace WinForms.App.Desktop
{
    partial class SliderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SliderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoayPhai = new System.Windows.Forms.Button();
            this.btnXoayTrai = new System.Windows.Forms.Button();
            this.cmdCheDo = new System.Windows.Forms.ComboBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 488);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1259, 488);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChooseFile);
            this.panel2.Controls.Add(this.btnXoayPhai);
            this.panel2.Controls.Add(this.btnXoayTrai);
            this.panel2.Controls.Add(this.cmdCheDo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 136);
            this.panel2.TabIndex = 1;
            // 
            // btnXoayPhai
            // 
            this.btnXoayPhai.Location = new System.Drawing.Point(423, 46);
            this.btnXoayPhai.Name = "btnXoayPhai";
            this.btnXoayPhai.Size = new System.Drawing.Size(94, 29);
            this.btnXoayPhai.TabIndex = 1;
            this.btnXoayPhai.Text = "Xoay phai";
            this.btnXoayPhai.UseVisualStyleBackColor = true;
            this.btnXoayPhai.Click += new System.EventHandler(this.btnXoayPhai_Click);
            // 
            // btnXoayTrai
            // 
            this.btnXoayTrai.Location = new System.Drawing.Point(323, 46);
            this.btnXoayTrai.Name = "btnXoayTrai";
            this.btnXoayTrai.Size = new System.Drawing.Size(94, 29);
            this.btnXoayTrai.TabIndex = 1;
            this.btnXoayTrai.Text = "Xoay trai";
            this.btnXoayTrai.UseVisualStyleBackColor = true;
            this.btnXoayTrai.Click += new System.EventHandler(this.btnXoayTrai_Click);
            // 
            // cmdCheDo
            // 
            this.cmdCheDo.FormattingEnabled = true;
            this.cmdCheDo.Items.AddRange(new object[] {
            "AutoSize",
            "Stretch",
            "Zoom",
            "Center"});
            this.cmdCheDo.Location = new System.Drawing.Point(106, 47);
            this.cmdCheDo.Name = "cmdCheDo";
            this.cmdCheDo.Size = new System.Drawing.Size(151, 28);
            this.cmdCheDo.TabIndex = 0;
            this.cmdCheDo.SelectedIndexChanged += new System.EventHandler(this.cmdCheDo_SelectedIndexChanged);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(1089, 47);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(94, 29);
            this.btnChooseFile.TabIndex = 2;
            this.btnChooseFile.Text = "Chọn file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // SliderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SliderForm";
            this.Text = "SliderForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private ComboBox cmdCheDo;
        private Button btnXoayPhai;
        private Button btnXoayTrai;
        private Button btnChooseFile;
    }
}