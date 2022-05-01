using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp48
{
    public partial class Ukol1 : Form
    {
        public Ukol1()
        {
            /*1. Zadejte počet prvků aritmetické posloupnosti n první prvek a1 a diferenci d. Pomocí
třídy List vytvořte seznam prvních n prvků aritmetické posloupnosti a seznam vypište.
Vytvořte metodu, která k zadanému Listu přidá zadaný počet prvků aritmetické
posloupnosti. Zavolejte metodu a seznam vypište.*/
            InitializeComponent();
        }
        List<String> list = new List<String>();
        public int d;

        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = (int)numericUpDown1.Value;
            d = (int)numericUpDown2.Value;
            int n = (int)numericUpDown3.Value;
            if(n==0) { return; }
            list.Add(a1.ToString());
            for(int i = 0;i<n-1;i++)
            {
                list.Add((Int32.Parse(list.Last()) + d).ToString());
            }
            listBox1.Items.AddRange(list.ToArray());
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = !false;
            button2.Enabled = !true;
            button3.Enabled = !true;
            list.Clear();
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown4.Value;
            for (int i = 0; i < n; i++)
            {
                list.Add((Int32.Parse(list.Last()) + d).ToString());
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(list.ToArray());
        }

        private void Ukol1_Load(object sender, EventArgs e)
        {

        }
    }
}
