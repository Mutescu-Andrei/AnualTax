using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema4
{
    public partial class TaxeAutovehicule : Form
    {
        double A=0, B, C, D, E,suma;


        public TaxeAutovehicule()
        {
            InitializeComponent();
        }

     

        private void Val_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
              
                e.Handled = true;
              
            }
            if (e.KeyChar == (char)Keys.Return)
            {
               
                e.Handled = true;
                A = Convert.ToDouble(Val.Text);
                comboBox2_SelectedIndexChanged(sender, e);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (comboBox2.Text.Equals("Hibride") || comboBox2.Text.Equals("Electrice") || comboBox2.Text.Equals("Euro 6"))
            {
                B = 0;
               
            }
            if (comboBox2.Text.Equals("Euro 5") || comboBox2.Text.Equals("Euro 4") || comboBox2.Text.Equals("Euro 3"))
            {
                if (A <= 120)
                    B = 0;
                else if (A > 121 && A <= 210)
                    B = 1;
                else if (A > 211 && A < 270)
                    B = 4;
                else if (A >= 271)
                    B = 8;
             }

            if (comboBox2.Text.Equals("Euro 2") || comboBox2.Text.Equals("Euro 1") || comboBox2.Text.Equals("Non-Euro"))
            {
                B = 16;
                
            }

           
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Introduceti data producerii autovehiculului");
        }

        private void Cil_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                e.Handled = true;

            }
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                Cil_Validated(sender, e);
            }
        }
        private void Data_CloseUp(object sender, EventArgs e)
        {
            string anvechi = Data.Value.ToString("M/d/yyyy");
            string ancurent = DateTime.Now.ToString("M/d/yyyy");

            String[] anv = anvechi.Split('/');
            String[] anc = ancurent.Split('/');
            int z1, z2, l1, l2, a1, a2;
            z1 = Convert.ToInt32(anv[1]);
            l1 = Convert.ToInt32(anv[0]);
            a1 = Convert.ToInt32(anv[2]);

            z2 = Convert.ToInt32(anc[1]);
            l2 = Convert.ToInt32(anc[0]);
            a2 = Convert.ToInt32(anc[2]);

            int ac, lc;

            if (l2 < l1)
            {
                a2 = a2 - 1;

            }
            ac = a2 - a1;
            lc = l2 - l1;

            if (ac < 1)
            {
                E = 10;

            }
            else if (ac < 3)
                E = 30;
            else if (ac < 5)
                E = 40;
            else if (ac < 10)
                E = 60;
            else E = 80;

            if (a1 == a2 && lc <= 6 && lc >= 0)
                E = 0;


        }
        private void button1_Click(object sender, EventArgs e)
        { 
            suma = (((A * B * 0.3) + (C * D * 0.7)) * ((100 - E) /100.00)) / 100;

            rez.Text = "";
            rez.Text += "A = "+ A+"\r\n";
            rez.Text += "B = " + B + "\r\n";
            rez.Text += "C = " + C + "\r\n";
            rez.Text += "D = " + D + "\r\n";
            rez.Text += "E = " + E + "\r\n";
            rez.Text += "suma = " + suma + "\r\n";
        }
        private void Val_Validated(object sender, EventArgs e)
        {
            A = Convert.ToDouble(Val.Text);
            comboBox2_SelectedIndexChanged(sender, e);

        }

        private void Cil_Validated(object sender, EventArgs e)
        {
            C = Convert.ToDouble(Cil.Text);
            
                if (comboBox2.Text.Equals("Hibride") || comboBox2.Text.Equals("Electrice") || comboBox2.Text.Equals("Euro 6"))
                    D = 0;

                if (C <= 2000)
                {
                    if (comboBox2.Text.Equals("Euro 5"))
                        D = 1.3;
                    if (comboBox2.Text.Equals("Euro 4"))
                        D = 0.13;
                    if (comboBox2.Text.Equals("Euro 3") || comboBox2.Text.Equals("Euro 2") || comboBox2.Text.Equals("Euro 1") || comboBox2.Text.Equals("Non-Euro"))
                        D = 9;
                }

                if (C >= 2001)
                {
                    if (comboBox2.Text.Equals("Euro 5"))
                        D = 0.39;
                    if (comboBox2.Text.Equals("Euro 4"))
                        D = 3;
                    if (comboBox2.Text.Equals("Euro 3") || comboBox2.Text.Equals("Euro 2") || comboBox2.Text.Equals("Euro 1") || comboBox2.Text.Equals("Non-Euro"))
                        D = 16;
                }
          

        }
    }
        
}
