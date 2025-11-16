namespace Bai01
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
            this.Load += Form1_Load;
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
            this.Shown += Form1_Shown;
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Form closed.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("Form closing.");
            DialogResult res= MessageBox.Show("Ban xac nhan dong form?", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Form Shown.");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Console.WriteLine("Form deactivate.");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("Form activated.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form Load.");
        }

        #endregion
    }
}
