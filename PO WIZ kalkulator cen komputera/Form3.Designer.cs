namespace PO_WIZ_kalkulator_cen_komputera
{
    partial class Form3
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
            ListViewItem listViewItem6 = new ListViewItem(new string[] { " Iiyama G-Master ", "679" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Iiyama G-Master Red Eagle", "1389" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "ASUS VU279CFE-B", "849" }, -1);
            ListViewItem listViewItem9 = new ListViewItem(new string[] { " Dell U2723QE", "450" }, -1);
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "Samsung Odyssey G5", "1298" }, -1);
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            Model = new ColumnHeader();
            listView1 = new ListView();
            Cena = new ColumnHeader();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(269, 440);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(74, 523);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 446);
            label1.Name = "label1";
            label1.Size = new Size(80, 41);
            label1.TabIndex = 3;
            label1.Text = "cena";
            // 
            // button2
            // 
            button2.Location = new Point(331, 523);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 4;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            // 
            // Model
            // 
            Model.Text = "Model";
            Model.Width = 350;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Model, Cena });
            listView1.FullRowSelect = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10 });
            listView1.Location = new Point(74, 42);
            listView1.Name = "listView1";
            listView1.Size = new Size(506, 357);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged_1;
            // 
            // Cena
            // 
            Cena.Text = "Cena";
            Cena.Width = 150;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 602);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button button2;
        private ColumnHeader Model;
        private ListView listView1;
        private ColumnHeader Cena;
    }
}