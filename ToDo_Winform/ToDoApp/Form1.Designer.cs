namespace ToDoApp
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
            tabControl1 = new TabControl();
            Shopping = new TabPage();
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            textBox1 = new TextBox();
            Work = new TabPage();
            Personal = new TabPage();
            tabControl1.SuspendLayout();
            Shopping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Shopping);
            tabControl1.Controls.Add(Work);
            tabControl1.Controls.Add(Personal);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Shopping
            // 
            Shopping.Controls.Add(label3);
            Shopping.Controls.Add(panel1);
            Shopping.Controls.Add(button1);
            Shopping.Controls.Add(label2);
            Shopping.Controls.Add(numericUpDown1);
            Shopping.Controls.Add(label1);
            Shopping.Controls.Add(textBox1);
            Shopping.Location = new Point(4, 24);
            Shopping.Name = "Shopping";
            Shopping.Padding = new Padding(3);
            Shopping.Size = new Size(792, 422);
            Shopping.TabIndex = 0;
            Shopping.Text = "Shopping";
            Shopping.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(558, 14);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 6;
            label3.Text = "To do";
            // 
            // panel1
            // 
            panel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.Location = new Point(346, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 367);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(56, 174);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 108);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(56, 126);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 58);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Shopping Item";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 0;
            // 
            // Work
            // 
            Work.Location = new Point(4, 24);
            Work.Name = "Work";
            Work.Padding = new Padding(3);
            Work.Size = new Size(792, 422);
            Work.TabIndex = 1;
            Work.Text = "Work";
            Work.UseVisualStyleBackColor = true;
            // 
            // Personal
            // 
            Personal.Location = new Point(4, 24);
            Personal.Name = "Personal";
            Personal.Size = new Size(792, 422);
            Personal.TabIndex = 2;
            Personal.Text = "Personal";
            Personal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Shopping.ResumeLayout(false);
            Shopping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Shopping;
        private TabPage Work;
        private TabPage Personal;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
        private Button button1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
    }
}