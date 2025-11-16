namespace Bai05
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
            Number1 = new Label();
            Number2 = new Label();
            Answer = new Label();
            PlusButton = new Button();
            MinusButton = new Button();
            MultiplyButton = new Button();
            DivideButton = new Button();
            num2_txtbox = new TextBox();
            Num1_txtbox = new TextBox();
            ans_txtbox = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Number1
            // 
            Number1.AutoSize = true;
            Number1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number1.Location = new Point(59, 29);
            Number1.Name = "Number1";
            Number1.Size = new Size(95, 28);
            Number1.TabIndex = 0;
            Number1.Text = "Number1";
            // 
            // Number2
            // 
            Number2.AutoSize = true;
            Number2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Number2.Location = new Point(59, 67);
            Number2.Name = "Number2";
            Number2.Size = new Size(95, 28);
            Number2.TabIndex = 1;
            Number2.Text = "Number2";
            // 
            // Answer
            // 
            Answer.AutoSize = true;
            Answer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Answer.Location = new Point(59, 211);
            Answer.Name = "Answer";
            Answer.Size = new Size(75, 28);
            Answer.TabIndex = 2;
            Answer.Text = "Answer";
            // 
            // PlusButton
            // 
            PlusButton.FlatAppearance.BorderSize = 0;
            PlusButton.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlusButton.ImageAlign = ContentAlignment.BottomCenter;
            PlusButton.Location = new Point(84, 128);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(50, 50);
            PlusButton.TabIndex = 3;
            PlusButton.Text = "+";
            PlusButton.TextImageRelation = TextImageRelation.ImageAboveText;
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += PlusButton_Click;
            // 
            // MinusButton
            // 
            MinusButton.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinusButton.Location = new Point(168, 128);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(50, 50);
            MinusButton.TabIndex = 4;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.Font = new Font("Arial", 16F);
            MultiplyButton.Location = new Point(246, 128);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(50, 50);
            MultiplyButton.TabIndex = 5;
            MultiplyButton.Text = "x";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // DivideButton
            // 
            DivideButton.Font = new Font("Arial", 16F);
            DivideButton.Location = new Point(328, 128);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(50, 50);
            DivideButton.TabIndex = 6;
            DivideButton.Text = "/";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // num2_txtbox
            // 
            num2_txtbox.Location = new Point(171, 71);
            num2_txtbox.Name = "num2_txtbox";
            num2_txtbox.Size = new Size(125, 27);
            num2_txtbox.TabIndex = 2;
            // 
            // Num1_txtbox
            // 
            Num1_txtbox.Location = new Point(171, 33);
            Num1_txtbox.Name = "Num1_txtbox";
            Num1_txtbox.Size = new Size(125, 27);
            Num1_txtbox.TabIndex = 1;
            // 
            // ans_txtbox
            // 
            ans_txtbox.Location = new Point(171, 215);
            ans_txtbox.Name = "ans_txtbox";
            ans_txtbox.Size = new Size(125, 27);
            ans_txtbox.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(num2_txtbox);
            panel1.Controls.Add(ans_txtbox);
            panel1.Controls.Add(Number1);
            panel1.Controls.Add(Num1_txtbox);
            panel1.Controls.Add(Number2);
            panel1.Controls.Add(Answer);
            panel1.Controls.Add(DivideButton);
            panel1.Controls.Add(PlusButton);
            panel1.Controls.Add(MultiplyButton);
            panel1.Controls.Add(MinusButton);
            panel1.Location = new Point(31, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 295);
            panel1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 375);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Number1;
        private Label Number2;
        private Label Answer;
        private Button PlusButton;
        private Button MinusButton;
        private Button MultiplyButton;
        private Button DivideButton;
        private TextBox num2_txtbox;
        private TextBox Num1_txtbox;
        private TextBox ans_txtbox;
        private Panel panel1;
    }
}
