using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PO_WIZ_kalkulator_cen_komputera
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        public string TextBoxText
        {
            get { return textBox3.Text; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

           
            form1.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedOption = comboBox1.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Intel Core i5-12400F":
                    textBox1.Text = "1312";
                    break;
                case "AMD Ryzen 7 5700X":
                    textBox1.Text = "1438";
                    break;
                case "Intel Core i5-13600KF":
                    textBox1.Text = "1965";
                    break;
                case "AMD Ryzen 7 5800X3D":
                    textBox1.Text = "2959";
                    break;
                case "AMD Ryzen 9 7950X":
                    textBox1.Text = "3252";
                    break;
                default:
                    textBox1.Text = "cena";
                    break;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int suma = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i) || i == e.Index && e.NewValue == CheckState.Checked)
                {
                    string item = checkedListBox1.Items[i].ToString();

                    switch (item)
                    {
                        case "Samsung 990 Evo Plus 2TB":
                            suma += 589;
                            break;
                        case "Kingston KC3000 M PCIe 4.0 NVMe 1TB":
                            suma += 358;
                            break;
                        case "Samsung 990 Pro 1TB":
                            suma += 463;
                            break;
                        case "Lexar NM790 PCIe NVMe 1TB":
                            suma += 309;
                            break;
                        case "Kingston NV2 M.2 PCIe 4.0 NVMe 1TB ":
                            suma += 299;
                            break;
                    }
                }
            }

            textBox2.Text = suma.ToString("0.00");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ObliczSume();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ObliczSume();
        }

        private void ObliczSume()
        {
            decimal cena1, cena2;

            if (decimal.TryParse(textBox1.Text, out cena1) && decimal.TryParse(textBox2.Text, out cena2))
            {
                decimal suma = cena1 + cena2;
                textBox3.Text = suma.ToString();
                
                // Konwersja do int z zaokrągleniem
                Class1.LiczbaZOkna2 = (int)Math.Round(suma);
            }
            else
            {
                textBox3.Text = "0";
                Class1.LiczbaZOkna2 = 0;
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
