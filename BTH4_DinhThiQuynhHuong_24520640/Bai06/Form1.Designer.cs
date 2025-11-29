namespace Bai06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            progressBar1 = new ProgressBar();
            groupBox_insert = new GroupBox();
            btn_copy = new Button();
            btn_OpenTarPath = new Button();
            btn_openSourcePath = new Button();
            tb_targetPath = new TextBox();
            tb_sourcePath = new TextBox();
            lb_TarPath = new Label();
            lb_sourcepath = new Label();
            groupBox_progress = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            groupBox_insert.SuspendLayout();
            groupBox_progress.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(26, 42);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(676, 29);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // groupBox_insert
            // 
            groupBox_insert.Controls.Add(btn_copy);
            groupBox_insert.Controls.Add(btn_OpenTarPath);
            groupBox_insert.Controls.Add(btn_openSourcePath);
            groupBox_insert.Controls.Add(tb_targetPath);
            groupBox_insert.Controls.Add(tb_sourcePath);
            groupBox_insert.Controls.Add(lb_TarPath);
            groupBox_insert.Controls.Add(lb_sourcepath);
            groupBox_insert.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_insert.ForeColor = Color.Blue;
            groupBox_insert.Location = new Point(26, 23);
            groupBox_insert.Name = "groupBox_insert";
            groupBox_insert.Size = new Size(722, 178);
            groupBox_insert.TabIndex = 1;
            groupBox_insert.TabStop = false;
            groupBox_insert.Text = "Sao chép tập tin";
            // 
            // btn_copy
            // 
            btn_copy.BackColor = SystemColors.ScrollBar;
            btn_copy.FlatStyle = FlatStyle.Popup;
            btn_copy.ForeColor = Color.Black;
            btn_copy.Location = new Point(247, 126);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new Size(192, 29);
            btn_copy.TabIndex = 6;
            btn_copy.Text = "Sao Chép";
            btn_copy.UseVisualStyleBackColor = false;
            btn_copy.Click += btn_copy_Click;
            // 
            // btn_OpenTarPath
            // 
            btn_OpenTarPath.BackColor = SystemColors.ScrollBar;
            btn_OpenTarPath.FlatStyle = FlatStyle.Flat;
            btn_OpenTarPath.ForeColor = Color.Black;
            btn_OpenTarPath.Location = new Point(666, 78);
            btn_OpenTarPath.Name = "btn_OpenTarPath";
            btn_OpenTarPath.Size = new Size(36, 25);
            btn_OpenTarPath.TabIndex = 5;
            btn_OpenTarPath.Text = "...";
            btn_OpenTarPath.UseVisualStyleBackColor = false;
            btn_OpenTarPath.Click += btn_OpenDesPath_Click;
            // 
            // btn_openSourcePath
            // 
            btn_openSourcePath.BackColor = SystemColors.ScrollBar;
            btn_openSourcePath.FlatStyle = FlatStyle.Flat;
            btn_openSourcePath.ForeColor = Color.Black;
            btn_openSourcePath.Location = new Point(666, 37);
            btn_openSourcePath.Name = "btn_openSourcePath";
            btn_openSourcePath.Size = new Size(36, 26);
            btn_openSourcePath.TabIndex = 4;
            btn_openSourcePath.Text = "...";
            btn_openSourcePath.UseVisualStyleBackColor = false;
            btn_openSourcePath.Click += btn_openSourcePath_Click;
            // 
            // tb_targetPath
            // 
            tb_targetPath.Location = new Point(247, 79);
            tb_targetPath.Name = "tb_targetPath";
            tb_targetPath.Size = new Size(401, 25);
            tb_targetPath.TabIndex = 3;
            // 
            // tb_sourcePath
            // 
            tb_sourcePath.Location = new Point(247, 39);
            tb_sourcePath.Name = "tb_sourcePath";
            tb_sourcePath.Size = new Size(401, 25);
            tb_sourcePath.TabIndex = 2;
            // 
            // lb_TarPath
            // 
            lb_TarPath.AutoSize = true;
            lb_TarPath.ForeColor = Color.Black;
            lb_TarPath.Location = new Point(47, 82);
            lb_TarPath.Name = "lb_TarPath";
            lb_TarPath.Size = new Size(186, 17);
            lb_TarPath.TabIndex = 1;
            lb_TarPath.Text = "Đường Dẫn Thư Mục Đích ";
            // 
            // lb_sourcepath
            // 
            lb_sourcepath.AutoSize = true;
            lb_sourcepath.ForeColor = Color.Black;
            lb_sourcepath.Location = new Point(47, 42);
            lb_sourcepath.Name = "lb_sourcepath";
            lb_sourcepath.Size = new Size(194, 17);
            lb_sourcepath.TabIndex = 0;
            lb_sourcepath.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // groupBox_progress
            // 
            groupBox_progress.Controls.Add(progressBar1);
            groupBox_progress.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_progress.ForeColor = Color.Blue;
            groupBox_progress.Location = new Point(26, 235);
            groupBox_progress.Name = "groupBox_progress";
            groupBox_progress.Size = new Size(722, 92);
            groupBox_progress.TabIndex = 2;
            groupBox_progress.TabStop = false;
            groupBox_progress.Text = "Tiến trình sao chép";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Rich text file (*.rtf)|*rtf|Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 356);
            Controls.Add(groupBox_progress);
            Controls.Add(groupBox_insert);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Sao chép tập tin";
            Load += Form1_Load;
            groupBox_insert.ResumeLayout(false);
            groupBox_insert.PerformLayout();
            groupBox_progress.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private ProgressBar progressBar1;
        private GroupBox groupBox_insert;
        private GroupBox groupBox_progress;
        private Label lb_TarPath;
        private Label lb_sourcepath;
        private Button btn_OpenTarPath;
        private Button btn_openSourcePath;
        private TextBox tb_targetPath;
        private TextBox tb_sourcePath;
        private OpenFileDialog openFileDialog1;
        private Button btn_copy;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
