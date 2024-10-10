

namespace ProyectoClase
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
            button1 = new Button();
            lbl_Name = new Label();
            lbl_Birth = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(560, 99);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(83, 103);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(0, 20);
            lbl_Name.TabIndex = 1;
            // 
            // lbl_Birth
            // 
            lbl_Birth.AutoSize = true;
            lbl_Birth.Location = new Point(245, 103);
            lbl_Birth.Name = "lbl_Birth";
            lbl_Birth.Size = new Size(0, 20);
            lbl_Birth.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Birth);
            Controls.Add(lbl_Name);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lbl_Name;
        private Label lbl_Birth;
    }
}
