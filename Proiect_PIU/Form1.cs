using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PIU
{
    public partial class Form1 : Form
    {//
        //IStocareData stocareData;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Introdu un nume");
            }
            else
            {
                Persoana p = new Persoana(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                //se adauga un element in lista
                if (radioButton1.Checked)
                    listBox1.Items.Add(p.ConversieLaSir());
                else if (radioButton2.Checked)
                    listBox2.Items.Add(p.ConversieLaSir());
                else if (radioButton3.Checked)
                    listBox3.Items.Add(p.ConversieLaSir());
                MessageBox.Show("Adaugare reusita!");
                ResetareControale();
            }
        }
        private void ResetareControale()
        {
            textBox1.Text = textBox2.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }
        public void AdaugaPersoanaInRichTextBox(Persoana p)
        {
            //TextBox.AppendText(p.ConversieLaSir());
            //TextBox.AppendText(Environment.NewLine);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stergere persoana din contacte");
            /*if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Introdu un nume");
            }
            else
            {
                foreach (Persoana p in stocareData.GetPersoana())
                {
                    List<Persoana> l = stocareData.GetPersoana();
                    Persoana pers = new Persoana(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    if (p == pers)
                    {
                        l.Remove(p);
                    }

                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Iurcu Ioana-Lacramioara, Grupa 3122C, An 2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualizare reusita");
            /*foreach(Persoana p in stocareData.GetPersoana())
            {
                List<Persoana> l = stocareData.GetPersoana();
                Persoana pers = new Persoana(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                if (p.Nume==pers.Nume && p.Prenume==pers.Prenume)
                {
                    
                }

            }*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
