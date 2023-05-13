using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace lab6
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static ListView l = new ListView();
        private void button1_Click(object sender, EventArgs e)
        {
            
         
          
            ListViewItem item = new ListViewItem(textBox1.Text);
            item.SubItems.Add(textBox2.Text);
            string g = "";
            if(radioButton1.Checked==true)
            {
                g = "male";
            }
            else { g = "female"; }
            item.SubItems.Add(g);
            item.SubItems.Add(textBox3.Text);
            item.SubItems.Add(richTextBox1.Text);
            item.SubItems.Add(textBox4.Text);
            item.SubItems.Add(textBox5.Text);
            l.Items.Add(item);
            MessageBox.Show("Data saved");
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            richTextBox1.Text = null;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            show form = new show();
            form.Show();
            this.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
            textBox6.Visible = true;
            label9.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           /* foreach (ListViewItem n in l.Items)
            {
                string fk = n.SubItems[2].Text;
                MessageBox.Show("This" + fk);
               

            }*/
           
            foreach (ListViewItem n in l.Items)
            {
                string f = n.SubItems[3].Text;
               
                if (textBox6.Text.ToLower() == f.ToLower())
                {
                    
                    label9.Visible = false;
                    textBox1.Text = n.SubItems[0].Text;
                    textBox2.Text = n.SubItems[1].Text;
                    textBox3.Text = n.SubItems[3].Text;
                    richTextBox1.Text = n.SubItems[4].Text;
                    textBox4.Text = n.SubItems[5].Text;
                    textBox5.Text = n.SubItems[6].Text;
                    button8.Visible = true;
                    button6.Visible = false;
                    textBox6.Visible = false;

                }
               
                


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            textBox6.Visible = false;
            label9.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button3.Visible = true;
            button2.Visible = true;
            button1.Visible = true;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;
            richTextBox1.Text = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem n in l.Items)
            {
                string f = n.SubItems[3].Text;
                if (textBox6.Text.ToLower() == f.ToLower())
                {
                   n.SubItems[0].Text=textBox1.Text;
                    n.SubItems[1].Text=(textBox2.Text);
                    string g = "";
                    if (radioButton1.Checked == true)
                    {
                        g = "male";
                    }
                    else { g = "female"; }
                    n.SubItems[2].Text = (g);
                    n.SubItems[3].Text = (textBox3.Text);
                    n.SubItems[4].Text = (richTextBox1.Text);
                    n.SubItems[5].Text = (textBox4.Text);
                    n.SubItems[6].Text = (textBox5.Text);
                    
                    MessageBox.Show("Data Updated");
                    button6.Visible = true;
                    textBox6.Visible = true;
                    label9.Visible = true;
                    button8.Visible = false;
                    break;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           string fname = (textBox1.Text);
            string lname = textBox2.Text;
            string g = "";
            if (radioButton1.Checked == true)
            {
                g = "male";
            }
            else { g = "female"; }
            string gender = g;
            int phone = int.Parse(textBox3.Text);
            string addres = richTextBox1.Text;
            int wno = int.Parse(textBox4.Text);
            string wname = textBox5.Text;
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Table.mdf;Integrated Security=True";
            SqlConnection k = new SqlConnection(connection);
            string que = "INSERT INTO new (Firsname, Lastname, Gender, Contactnumer, Address, Wno, Wname) VALUES('"+fname+"','"+lname+"','"+gender+"','"+phone+"','"+addres+"','"+wno+"','"+wname+"')";
            SqlCommand b = new SqlCommand(que, k);
            k.Open();
            int n = b.ExecuteNonQuery();
            if (n >= 1)
            {
                MessageBox.Show("Data Inserted", "Done", MessageBoxButtons.OKCancel);

            }
            else
            {
                MessageBox.Show("Data  Not Inserted", "eror", MessageBoxButtons.OKCancel);
            }
            /* string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Table.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(connection);
            string query = "INSERT INTO Table (Firsname, Lastname, Gender, Contactnumer,Address,Wno,Wname) VALUES('" + fname + "', '" + lname + "', '" + gender + "', '" + phone + "', '"+addres+"', '"+wno+"','"+wname+")";
            SqlCommand cmd = new SqlCommand(query, cn);
            cn.Open();
            int k = cmd.ExecuteNonQuery();
            if (k >= 1)
            {
                MessageBox.Show("Data Inserted", "Done", MessageBoxButtons.OKCancel);
               
            }
            else
            {
                MessageBox.Show("Data  Not Inserted", "eror", MessageBoxButtons.OKCancel);
            }*/

        }
    }
}
