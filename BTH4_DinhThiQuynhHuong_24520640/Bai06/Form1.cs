using System.Diagnostics;

namespace Bai06
{
    public partial class Form1 : Form
    {
        private string sourcePath;
        private string targetPath;
        string targetFile;
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_openSourcePath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourcePath = openFileDialog1.FileName;
                tb_sourcePath.Text = sourcePath;
            }
        }

        private void btn_OpenDesPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                targetPath = folderBrowserDialog1.SelectedPath;
                tb_targetPath.Text = targetPath;
            }
        }


        private void CopyFileWithProgress( ProgressBar progressBar, ToolTip toolTip1)
        {            
            targetFile = Path.Combine(targetPath, fileName);

            long fileLength = new FileInfo(sourcePath).Length;

            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            const int bufferSize = 1024 * 1024; // 1MB
            byte[] buffer = new byte[bufferSize];
            long totalRead = 0;

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destStream = new FileStream(targetFile, FileMode.Create, FileAccess.Write))
            {
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destStream.Write(buffer, 0, bytesRead);
                    totalRead += bytesRead;

                    int percent = (int)((totalRead * 100) / fileLength);
                    progressBar.Value = percent;

                    /*if (percent == 100) {
                        
                        DialogResult res= MessageBox.Show("Sao chép thành công!", "Thông báo", MessageBoxButtons.OK);
                        if(res == DialogResult.OK) {
                            progressBar.Value = 0;
                        }

                    }*/

                    Application.DoEvents();
                }
            }
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            sourcePath = tb_sourcePath.Text;
            targetPath = tb_targetPath.Text;
            fileName = Path.GetFileName(sourcePath);
            CopyFileWithProgress(progressBar1, toolTip1);
            targetFile = Path.Combine(targetPath, fileName);

            toolTip1.SetToolTip(progressBar1, $"Dang sao chép : {targetFile}");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(progressBar1, $"Dang sao chép : {targetFile}");
        }
    }
}
