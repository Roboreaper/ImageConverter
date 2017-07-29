using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class FormImageConvert : Form
    {        
        public FormImageConvert()
        {
            InitializeComponent();
        }


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Select a folder to convert";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;

            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                textBoxFolder.Text = fbd.SelectedPath;

                var files = System.IO.Directory.GetFiles(textBoxFolder.Text);
                InfoMessage($"{files.Count()} files found in folder {textBoxFolder.Text}");
            }          
        }

        bool converting = false;
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (converting)
                tokenSource.Cancel();

            if (string.IsNullOrEmpty(textBoxFolder.Text))
            {
                MessageBox.Show(this, "Please browse or enter a folder location");
                return;
            }

            if (!System.IO.Directory.Exists(textBoxFolder.Text))
            {
                MessageBox.Show(this, "Folder location is not valid");
                return;
            }


            var files = System.IO.Directory.GetFiles(textBoxFolder.Text);

            if (files.Count() < 1)
            {
                MessageBox.Show(this, "No Files in folder");
                return;
            }

            converting = true;
            buttonConvert.Text = "Cancel";

            progressBar1.Minimum = 1;
            progressBar1.Maximum = files.Count();
            progressBar1.Step = 1;

            textBoxInfo.Text = "";
            textBoxInfo.Text = "Start Conversion..." + Environment.NewLine;            

            ConvertFiles(files);

            buttonConvert.Text = "Convert";
            converting = false;

        }   

        CancellationTokenSource tokenSource = new CancellationTokenSource();
        private async void ConvertFiles(string[] files)
        {          
            await Task.Run(() =>
            {
                var backup = Path.Combine(System.IO.Path.GetDirectoryName(files.First()), "Backup");
                try
                {
                    if (!Directory.Exists(backup))
                        Directory.CreateDirectory(backup);
                }
                catch (Exception e)
                {
                    InfoMessage(e.Message);
                }

                foreach (var file in files)
                {
                    if (tokenSource.Token.IsCancellationRequested)
                        break;

                    var ext = System.IO.Path.GetExtension(file);
                    if (ext.Equals(".pptx", StringComparison.InvariantCultureIgnoreCase) || ext.Equals(".ppt", StringComparison.InvariantCultureIgnoreCase))
                    {
                        if(file.Contains("~$"))
                            continue; // ignore this file
                    }

                    ImageTools.ConvertFromFile(backup,file, InfoMessage);
                    UpdateProgressBar();                   
                }              
                
            }, tokenSource.Token);

            InfoMessage("Conversion Finised.");
           
        }

        private void UpdateProgressBar()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { UpdateProgressBar(); }));
            }
            else
            {
                this.progressBar1.PerformStep();                
            }
        }

        public void InfoMessage(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => { InfoMessage(msg); }));
            }
            else
            {
                textBoxInfo.AppendText(msg + Environment.NewLine);
                textBoxInfo.Refresh();
            }
        }
    }
}
