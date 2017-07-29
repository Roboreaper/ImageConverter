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
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.textBoxIntro = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.textBoxFolder, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonBrowse, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonConvert, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.progressBar1, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxInfo, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxIntro, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(563, 230);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFolder.Location = new System.Drawing.Point(3, 80);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(444, 20);
            this.textBoxFolder.TabIndex = 0;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowse.Location = new System.Drawing.Point(453, 80);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(107, 19);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConvert.Location = new System.Drawing.Point(453, 105);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(107, 23);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // textBoxInfo
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxInfo, 2);
            this.textBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInfo.Location = new System.Drawing.Point(3, 134);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInfo.Size = new System.Drawing.Size(557, 93);
            this.textBoxInfo.TabIndex = 4;
            // 
            // textBoxIntro
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxIntro, 2);
            this.textBoxIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIntro.Location = new System.Drawing.Point(3, 3);
            this.textBoxIntro.Multiline = true;
            this.textBoxIntro.Name = "textBoxIntro";
            this.textBoxIntro.ReadOnly = true;
            this.textBoxIntro.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxIntro.Size = new System.Drawing.Size(557, 71);
            this.textBoxIntro.TabIndex = 5;
            this.textBoxIntro.Text = "Selecteer een Folder. \r\nAlle bestanden worden omgezet en alle originele bestanden" +
    " worden naar een backup folder verplaatst.\r\nondersteunde formaten: ppt , pptx , " +
    "jpg, png.\r\n";
            // 
            // FormImageConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 230);
            this.Controls.Add(this.tableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImageConvert";
            this.Text = "Image Converter v3";
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
    }
}

