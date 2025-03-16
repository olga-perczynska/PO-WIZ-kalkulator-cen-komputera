namespace PO_WIZ_kalkulator_cen_komputera
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
            bMonitor = new Button();
            textBox1 = new TextBox();
            bKomputer = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // bMonitor
            // 
            bMonitor.Location = new Point(293, 179);
            bMonitor.Name = "bMonitor";
            bMonitor.Size = new Size(188, 58);
            bMonitor.TabIndex = 1;
            bMonitor.Text = "Monitor";
            bMonitor.UseVisualStyleBackColor = true;
            bMonitor.Click += bMonitor_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(538, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 2;
            // 
            // bKomputer
            // 
            bKomputer.Location = new Point(47, 179);
            bKomputer.Name = "bKomputer";
            bKomputer.Size = new Size(188, 58);
            bKomputer.TabIndex = 3;
            bKomputer.Text = "Komputer";
            bKomputer.UseVisualStyleBackColor = true;
            bKomputer.Click += bKomputer_Click;
            // 
            // button1
            // 
            button1.Location = new Point(538, 84);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 4;
            button1.Text = "Oblicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(bKomputer);
            Controls.Add(textBox1);
            Controls.Add(bMonitor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bMonitor;
        private TextBox textBox1;
        private Button bKomputer;
        private Button button1;
    }
}
