using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFunctionality
{
    public partial class Form1 : Form
    {
        List<string> FruitList = new List<string>();
       
        public Form1()
        {
            InitializeComponent();

            FruitList.Add("Orange");
            FruitList.Add("Apple");
            FruitList.Add("Banana");
            FruitList.Add("Strawberry");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = textBox1.Text;
            FruitList.Add(f);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string fruit in FruitList)
            {
                listBox1.Items.Add(fruit);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, listBox1.Items.Count);
            label1.Text = "The random number is: " + number; 
            textBox2.Text = listBox1.GetItemText(listBox1.Items[number-1]);

        }
    }
}
