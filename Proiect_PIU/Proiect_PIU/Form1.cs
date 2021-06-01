using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Proiect_PIU
{
    public partial class Form1 : Form
    {
        List<Persoana> list_persoane = new List<Persoana>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Validare())
            {
                Persoana p = new Persoana(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                //se adauga un element in lista
                list_persoane.Add(p);
                //AdaugaPersoanaInListBox(p);
                MessageBox.Show("Adaugare reusita!");
                ResetareControale();
            }
        }
        private bool Validare()
        {
            bool ok = true ;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Introdu un nume");
                ok = false;
            }
            else if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Introdu un prenume");
                ok = false;
            }
            else if (textBox3.Text == String.Empty)
            {
                MessageBox.Show("Introdu ziua de nastere(zz/ll/aaaa) ");
                ok = false;
            }
            else if (textBox4.Text == String.Empty)
            {
                MessageBox.Show("Introdu numarul de telefon");
                ok = false;
            }
            else if (textBox5.Text == String.Empty)
            {
                MessageBox.Show("Introdu o adresa de email(example@example.com)");
                ok = false;
            }
            return ok;
         }
        private void ResetareControale()
        {
            textBox1.Text = textBox2.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

        }
        private void AdaugaPersoanaInListBox(Persoana p)
        {
            if (radioButton1.Checked)
                listBox1.Items.Add(p.ConversieLaSir());
            else if (radioButton2.Checked)
                listBox2.Items.Add(p.ConversieLaSir());
            else if (radioButton3.Checked)
                listBox3.Items.Add(p.ConversieLaSir());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //stergere persoana prin selectare
            int itemsSelected = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(itemsSelected);
            listBox2.Items.RemoveAt(itemsSelected);
            listBox3.Items.RemoveAt(itemsSelected);
            list_persoane.RemoveAt(itemsSelected); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //info autor
            MessageBox.Show("Autor: Iurcu Ioana-Lacramioara, Grupa 3122C, An 2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //cautare persoana 
            bool ok = false;
            Persoana p = new Persoana(textBox1.Text,textBox2.Text);
            foreach(Persoana pers in list_persoane)
            {
                if(pers.Nume== p.Nume && pers.Prenume== p.Prenume)
                {
                    MessageBox.Show("Persoana a fost gasita!");
                    ok = true;
                }
            }
            if (ok == false)
                MessageBox.Show("Persoana nu a fost gasita!");
            

        }
        private void button5_Click(object sender, EventArgs e)
        {
            //afisare pentru fiecare RadioButton
            listBox1.Items.Clear();
            foreach (Persoana p in list_persoane)
                AdaugaPersoanaInListBox(p);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
