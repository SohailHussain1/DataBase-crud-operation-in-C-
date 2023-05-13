using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class show : Form
    {
        public show()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // ListViewItem itel = new ListViewItem();
            foreach(ListViewItem n in Form1.l.Items)
            {
                listView1.Items.Add((ListViewItem)n.Clone());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(ListViewItem n in Form1.l.Items)
            {
                string f = n.SubItems[1].Text;
                if (textBox2.Text.ToLower() ==f.ToLower())
                {
                    listView1.Items.Add((ListViewItem)n.Clone());
                }
              
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
