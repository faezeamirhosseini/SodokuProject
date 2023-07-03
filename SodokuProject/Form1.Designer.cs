namespace SodokuProject
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
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            SuspendLayout();
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonFace;
            btn3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = Color.MidnightBlue;
            btn3.Location = new Point(599, 266);
            btn3.Name = "btn3";
            btn3.Size = new Size(189, 47);
            btn3.TabIndex = 5;
            btn3.Text = "See The Answer";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonFace;
            btn2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = Color.MidnightBlue;
            btn2.Location = new Point(599, 329);
            btn2.Name = "btn2";
            btn2.Size = new Size(189, 47);
            btn2.TabIndex = 4;
            btn2.Text = "New Sodoku";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonFace;
            btn1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = Color.MidnightBlue;
            btn1.Location = new Point(599, 391);
            btn1.Name = "btn1";
            btn1.Size = new Size(189, 47);
            btn1.TabIndex = 3;
            btn1.Text = "Check The Answer";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn3;
        private Button btn2;
        private Button btn1;
    }
}