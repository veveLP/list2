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
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            /*2. Zadejte počet prvků geometrické posloupnosti n první dva prvky a1, a2. Pomocí třídy
List vytvořte seznam prvních n prvků geometrické posloupnosti a seznam vypište.
Vytvořte metodu, která pro zadaný List a zadaný počet prvků p posloupnosti zjistí, zda
list obsahuje dostatečný počet prvků a spočítá součet prvních p prvků. Metodu
zavolejte a vypište výsledek.*/
            InitializeComponent();
        }
        List<String> list = new List<String>();
        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = (int)numericUpDown1.Value;
            int a2 = (int)numericUpDown2.Value;
            int n = (int)numericUpDown3.Value;
            //if (!(a1 < a2)) { return; }
            double d = (double)a2 / (double)a1;
            list.Add(a1.ToString());
            for (int i = 0; i < n; i++)
            {
                list.Add((Double.Parse(list.Last()) * d).ToString());
            }
            listBox1.Items.AddRange(list.ToArray());
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void Ukol2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = !false;
            button2.Enabled = !true;
            button3.Enabled = !true;
            list.Clear();
            listBox1.Items.Clear();
        }

        private void metodaIdk(List<String> list, int p) {
            if(list.Count<p) { MessageBox.Show("List nemá dostatek prvků!"); return; }
            double souc = 0;
            for(int i = 0;i<p;i++)
            {
                souc += Double.Parse(list[i]);
            }
            MessageBox.Show("Soucet je:" + souc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            metodaIdk(list, (int)numericUpDown4.Value);
        }
    }
}
