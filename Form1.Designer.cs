namespace ImageConverter
{
    partial class FormImageConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImageConvert));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.textBoxIntro = new System.Windows.Forms.TextBox();
            this.buttonSelectLogo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.logoSelecter1 = new ImageConverter.LogoSelecter();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.textBox3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBox2, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxFolder, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonBrowse, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonConvert, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.progressBar1, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxInfo, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxIntro, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.logoSelecter1, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonSelectLogo, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(558, 260);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(3, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(105, 13);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Logo";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(105, 13);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Voortgang";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolder.Location = new System.Drawing.Point(114, 80);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(328, 20);
            this.textBoxFolder.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowse.Location = new System.Drawing.Point(448, 80);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(107, 24);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConvert.Location = new System.Drawing.Point(448, 140);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(107, 24);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(114, 140);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(328, 24);
            this.progressBar1.TabIndex = 3;
            // 
            // textBoxInfo
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxInfo, 3);
            this.textBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo.Location = new System.Drawing.Point(3, 170);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInfo.Size = new System.Drawing.Size(552, 87);
            this.textBoxInfo.TabIndex = 4;
            // 
            // textBoxIntro
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxIntro, 3);
            this.textBoxIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIntro.Location = new System.Drawing.Point(3, 3);
            this.textBoxIntro.Multiline = true;
            this.textBoxIntro.Name = "textBoxIntro";
            this.textBoxIntro.ReadOnly = true;
            this.textBoxIntro.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIntro.Size = new System.Drawing.Size(552, 71);
            this.textBoxIntro.TabIndex = 5;
            this.textBoxIntro.Text = "Selecteer een Folder. \r\nAlle bestanden worden omgezet en alle originele bestanden" +
    " worden naar een backup folder verplaatst.\r\nondersteunde formaten: ppt , pptx , " +
    "jpg, png.\r\n";
            // 
            // buttonSelectLogo
            // 
            this.buttonSelectLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectLogo.Location = new System.Drawing.Point(448, 110);
            this.buttonSelectLogo.Name = "buttonSelectLogo";
            this.buttonSelectLogo.Size = new System.Drawing.Size(107, 24);
            this.buttonSelectLogo.TabIndex = 7;
            this.buttonSelectLogo.Text = "Select Logo";
            this.buttonSelectLogo.UseVisualStyleBackColor = true;
            this.buttonSelectLogo.Click += new System.EventHandler(this.buttonSelectLogo_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(105, 13);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Bestanden";
            // 
            // logoSelecter1
            // 
            this.logoSelecter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoSelecter1.Location = new System.Drawing.Point(112, 108);
            this.logoSelecter1.Margin = new System.Windows.Forms.Padding(1);
            this.logoSelecter1.Name = "logoSelecter1";
            this.logoSelecter1.Size = new System.Drawing.Size(332, 28);
            this.logoSelecter1.TabIndex = 6;
            // 
            // FormImageConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 260);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImageConvert";
            this.Text = "Image Converter v5.1";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.TextBox textBoxIntro;
        private LogoSelecter logoSelecter1;
        private System.Windows.Forms.Button buttonSelectLogo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

