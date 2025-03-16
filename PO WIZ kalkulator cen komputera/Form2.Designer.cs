namespace PO_WIZ_kalkulator_cen_komputera
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 84);
            label1.Name = "label1";
            label1.Size = new Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Procesor";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(262, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Intel Core i5-12400F", "AMD Ryzen 7 5700X", "Intel Core i5-13600KF", "AMD Ryzen 7 5800X3D", "AMD Ryzen 9 7950X" });
            comboBox1.Location = new Point(73, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(442, 49);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(262, 252);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 258);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 3;
            label2.Text = "Dysk";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Samsung 990 Evo Plus 2TB", "Kingston KC3000 M PCIe 4.0 NVMe 1TB", "Samsung 990 Pro 1TB", "Lexar NM790 PCIe NVMe 1TB", "Kingston NV2 M.2 PCIe 4.0 NVMe 1TB " });
            checkedListBox1.Location = new Point(0, 334);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(571, 224);
            checkedListBox1.TabIndex = 5;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 587);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 47);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 593);
            label3.Name = "label3";
            label3.Size = new Size(92, 41);
            label3.TabIndex = 6;
            label3.Text = "Suma";
            // 
            // button1
            // 
            button1.Location = new Point(73, 711);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 8;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(297, 711);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 9;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 835);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(checkedListBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}