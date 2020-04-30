using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DODO_Pitsa.Modules;

namespace DODO_Pitsa
{
    public partial class MainMenu : Form
    {
        long costs;
        int items;
        public MainMenu()
        {
            InitializeComponent();
            Methods Methods = new Methods();
            GenForms GenForms = new GenForms();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            hello_name.Text += Methods.GlobalVars.arr[Methods.GlobalVars.auth_id].name;
            label27.Text += Methods.GlobalVars.arr[Methods.GlobalVars.auth_id].name;
            label28.Text += Methods.GlobalVars.arr[Methods.GlobalVars.auth_id].phone;
            label29.Text += Methods.GlobalVars.arr[Methods.GlobalVars.auth_id].addr;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            listBox1.Items.Insert(items, label2.Text + " " + label6.Text.ToString() + " x " + textBox1.Text.ToString() + " Cумма: " + Convert.ToInt64(textBox1.Text) * Convert.ToInt64(label6.Text.Remove(3)));
            long sum = Convert.ToInt64(textBox1.Text) * Convert.ToInt64(label6.Text.Remove(3));
            costs = costs + sum;
            label32.Text = "Итого: " + costs + " р";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(items, label10.Text + " " + label7.Text.ToString() + " x " + textBox2.Text.ToString() + " Cумма: " + Convert.ToInt64(textBox2.Text) * Convert.ToInt64(label7.Text.Remove(3)));
            long sum = Convert.ToInt64(textBox2.Text) * Convert.ToInt64(label7.Text.Remove(3));
            costs = costs + sum;
            label32.Text = "Итого: " + costs + " р";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ оформлен", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information , MessageBoxDefaultButton.Button1);  
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(items, label14.Text + " " + label11.Text.ToString() + " x " + textBox3.Text.ToString() + " Cумма: " + Convert.ToInt64(textBox3.Text) * Convert.ToInt64(label11.Text.Remove(3)));
            long sum = Convert.ToInt64(textBox3.Text) * Convert.ToInt64(label11.Text.Remove(3));
            costs = costs + sum;
            label32.Text = "Итого: " + costs + " р";
     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(items, label18.Text + " " + label15.Text.ToString() + " x " + textBox4.Text.ToString() + " Cумма: " + Convert.ToInt64(textBox4.Text) * Convert.ToInt64(label15.Text.Remove(3)));
            long sum = Convert.ToInt64(textBox4.Text) * Convert.ToInt64(label15.Text.Remove(3));
            costs = costs + sum;
            label32.Text = "Итого: " + costs + " р";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(items, label22.Text + " " + label19.Text.ToString() + " x " + textBox5.Text.ToString() + " Cумма: " + Convert.ToInt64(textBox5.Text) * Convert.ToInt64(label19.Text.Remove(3)));
            long sum = Convert.ToInt64(textBox5.Text) * Convert.ToInt64(label19.Text.Remove(3));
          
            costs = costs + sum;
            label32.Text = "Итого: " + costs + " р";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(items, label26.Text + " " + label23.Text.ToString() + " x " + textBox6.Text.ToString() + " Cумма: " + Convert.ToInt64(textBox6.Text) * Convert.ToInt64(label23.Text.Remove(3)));
            long sum = Convert.ToInt64(textBox6.Text) * Convert.ToInt64(label23.Text.Remove(3));
            costs = costs + sum;
            label32.Text = "Итого: "+costs + " р";
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GenForms.About();
        }
    }
}