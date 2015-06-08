using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Moj_Broj
{
    public partial class Form1 : Form
    {
        private int broj1 = 0;
        private int broj2 = 0;
        private int broj3 = 0;
        private int broj4 = 0;
        private int broj5 = 0;
        private int broj6 = 0;
        private int trazeniBroj = 0;
        private int dobijeniBroj = 0;

        private Random randomizer;
        private DataTable resavac;

        string value = "";
        string brojbroj = "";

        int vremezaodbrojavanje = 90;

        bool Done = false;
        bool proverabr = false;
        bool proverazagrade = false;

        string CurValue = "";

        public Form1()
        {
            InitializeComponent();
            lblResavanjeUToku.Visible = false;
            resavac = new DataTable();
        }

  
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            randomizer = new Random();
            Timer1.Start();

            RandomingNumbers();
        }
        
        private void RandomingNumbers()
        {
            Random rnd = new Random();
            int valueone = rnd.Next(1, 999);
            TBTrazeni.Text = valueone.ToString();
            
            int valuetwo = rnd.Next(1, 10);
            TBJedan.Text = valuetwo.ToString();
            int valuethree = rnd.Next(1, 10);
            TBDva.Text = valuethree.ToString();
            int valuefour = rnd.Next(1, 10);
            TBTri.Text = valuefour.ToString();
            int valuefive = rnd.Next(1, 10);
            TBCetiri.Text = valuefive.ToString();

            int value6 = rnd.Next(1, 4);
            if (value6 == 1)
            {
                TBPet.Text = 10.ToString();
            }
            if (value6 == 2)
            {
                TBPet.Text = 15.ToString();
            }
            if (value6 == 3)
            {
                TBPet.Text = 20.ToString();
            }


            int valueseven = rnd.Next(1, 5);
            if (valueseven == 1)
            {
                TBSest.Text = 25.ToString();
            }
            if (valueseven == 2)
            {
                TBSest.Text = 50.ToString();
            }
            if (valueseven == 3)
            {
                TBSest.Text = 75.ToString();
            }
            if (valueseven == 4)
            {
                TBSest.Text = 100.ToString();
            }
    
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            RandomingNumbers();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Timer1.Stop();

            btnStop.Enabled = false;
            btnPotvrdi.Enabled = true;
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnPuta.Enabled = true;
            btnPodeljeno.Enabled = true;
            Button8.Enabled = true;
            btnZagraduOtvori.Enabled = true;
            btnZagraduZatvori.Enabled = true;
            lblResavanjeUToku.Visible = true;

            Timer2.Start();
            VremeOdbrojavanje();
            trazeniBroj = Convert.ToInt32(TBTrazeni.Text);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Timer2.Stop();
            value = TextBox1.Text;
            brojbroj = TextBox1.Text;
            Timer2.Start();
        }

        private void VremeOdbrojavanje()
        {
            Timer3.Start();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            Timer3.Stop();
            vremezaodbrojavanje = vremezaodbrojavanje - 1;
            Label4.Text = vremezaodbrojavanje.ToString();
            Timer3.Start();
            ProveriTajmer();
        }

        private void ProveriTajmer()
        {
            if (vremezaodbrojavanje == 0)
            {
                lblResavanjeUToku.Text = "Vreme je isteklo!";
                Timer3.Stop();
                btnPotvrdi.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnZagraduZatvori.Enabled = false;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Application.Restart();
        } //restart aplikacije

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                proverabr = false;
                TextBox1.Text = "";
                TBDva.Tag = "";
                TBJedan.Tag = "";
                TBTri.Tag = "";
                TBCetiri.Tag = "";
                TBPet.Tag = "";
                TBSest.Tag = "";
                btnPotvrdi.Enabled = true;

                CurValue = "";
                value = "";
                Label5.Text = "0";
                broj1 = 0;
                broj2 = 0;
                broj3 = 0;
                broj4 = 0;
                broj5 = 0;
                broj6 = 0;

                TBJedan.BackColor = Color.White;
                TBDva.BackColor = Color.White;
                TBTri.BackColor = Color.White;
                TBCetiri.BackColor = Color.White;
                TBPet.BackColor = Color.White;
                TBSest.BackColor = Color.White;
            }
            catch (Exception)
            {
                throw;
            }
        }

      
        private void TBJedan_Click(object sender, EventArgs e)
        {
            if ((broj1 == 0) && (proverabr==false))
            {
                broj1 = Convert.ToInt32(TBJedan.Text);
                TBJedan.Tag = "1";
                TBJedan.BackColor = Color.DeepSkyBlue;
                AddDigitsToTextBox();
                proverabr = true;
            }
                      
        }

        private void AddDigitsToTextBox()
        {
            TextBox1.Text += broj1;      
        }
        
        private void TBDva_Click(object sender, EventArgs e)
        {
            if ((broj2 == 0) && (proverabr==false))
            {
                broj2 = Convert.ToInt32(TBDva.Text);
                TBDva.Tag = "1";
                TBDva.BackColor = Color.DeepSkyBlue;
                adddigitstotextbox2();
                proverabr = true;
            }
        }    

        private void adddigitstotextbox2()
        {
            TextBox1.Text += broj2;
        }

        private void TBTri_Click(object sender, EventArgs e)
        {
            if ((broj3 == 0) && (proverabr==false))
            {
                broj3 = Convert.ToInt32(TBTri.Text);
                TBTri.Tag = "1";
                TBTri.BackColor = Color.DeepSkyBlue;
                addidgis();
                proverabr = true;
            }
        }

        private void addidgis()
        {
            TextBox1.Text += broj3;
        }

        private void TBCetiri_Click(object sender, EventArgs e)
        {
            if ((broj4 == 0) && (proverabr==false))
            {
                broj4 = Convert.ToInt32(TBCetiri.Text);
                TBCetiri.Tag = "1";
                TBCetiri.BackColor = Color.DeepSkyBlue;
                addigiitsasa();
                proverabr = true;
            }
        }

        private void addigiitsasa()
        {
            TextBox1.Text += broj4;
        }

        private void TBPet_Click(object sender, EventArgs e)
                {
                    if ((broj5 == 0) && (proverabr==false))
                    {
                        broj5 = Convert.ToInt32(TBPet.Text);
                        TBPet.Tag = "1";
                        TBPet.BackColor = Color.DeepSkyBlue;
                        addigitalsias();
                        proverabr = true;
                    }
                }
        private void addigitalsias()
                {
                    TextBox1.Text += broj5;
                }
        //tbpet klik

        //tbsest klik
        private void TBSest_Click(object sender, EventArgs e)
               {
                   if ((broj6 == 0) && (proverabr==false))
                   {
                       broj6 = Convert.ToInt32(TBSest.Text);
                       TBSest.Tag = "1";
                       TBSest.BackColor = Color.DeepSkyBlue;
                       addingdigirssix();
                       proverabr = true;
                   }
               }
        private void addingdigirssix()
               {
                   TextBox1.Text += broj6;
               }
        //tbsest klik

        private void Button4_Click(object sender, EventArgs e) //klik na +
        {
            proverabr = false;
            if (TextBox1.Text.EndsWith("+"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("-"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("*"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("/"))
            {
                return;
            }
            else if (string.IsNullOrEmpty(TextBox1.Text))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("+"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("-"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("*"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("/"))
            {
                return;
            }
            else
            {
                TextBox1.Text = TextBox1.Text +  "+";
            }

        }
        private void Button7_Click(object sender, EventArgs e)
        {
            proverabr = false;
            if (TextBox1.Text.EndsWith("+"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("-"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("*"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("/"))
            {
                return;
            }
            else if (string.IsNullOrEmpty(TextBox1.Text))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("+"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("-"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("*"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("/"))
            {
                return;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "-";
            }

              } // klik na -
        private void Button6_Click(object sender, EventArgs e)
        {
            proverabr = false;
            if (TextBox1.Text.EndsWith("+"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("-"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("*"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("/"))
            {
                return;
            }
            else if (string.IsNullOrEmpty(TextBox1.Text))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("+"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("-"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("*"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("/"))
            {
                return;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "*";
            }
        } // klik na *
        private void Button5_Click(object sender, EventArgs e)
        {
            proverabr = false;
            if (TextBox1.Text.EndsWith("+"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("-"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("*"))
            {
                return;
            }
            else if (TextBox1.Text.EndsWith("/"))
            {
                return;
            }
            else if (string.IsNullOrEmpty(TextBox1.Text))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("+"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("-"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("*"))
            {
                return;
            }
            else if (TextBox1.Text.StartsWith("/"))
            {
                return;
            }
            else
            {
                TextBox1.Text = TextBox1.Text + "/";
            }
        } // klik na /
        private void Button9_Click(object sender, EventArgs e)
        {
            if (proverabr == true) 
            {
                proverazagrade = false;
            }
            else

            TextBox1.Text += "(";
        } // klik na (
        private void Button8_Click(object sender, EventArgs e)
        {
            if (proverabr == false)
            {
                proverazagrade = true;
            }
            else

            TextBox1.Text += ")";
        } // klik na )

        
        private void btnPotvrdi_Click(object sender, EventArgs e) //klik na potrvrdi
        {
            value = TextBox1.Text;
            Timer2.Stop();
            btnPotvrdi.Enabled = false;
            Done = true;
            CalculateNOW(); 
        }

        private void CalculateNOW()
        {
            try
            {
                object result = resavac.Compute(value, null);
                Console.WriteLine("rezultat formule je " + result.GetType().ToString());
                dobijeniBroj = Convert.ToInt32(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                  ShowingResults();
        }

        private void ShowingResults()
        {
            Timer3.Stop();
            btnZagraduZatvori.Enabled = false;
            if (trazeniBroj == dobijeniBroj)
            {
                lblResavanjeUToku.Text = "";
                lblResavanjeUToku.Text += "Vas broj je " + dobijeniBroj + "." + "Dobili ste tacan broj! Bravo!";
                Label5.Text = Convert.ToString(dobijeniBroj);
            }
            else
            {
                lblResavanjeUToku.Text = "";
                lblResavanjeUToku.Text += "Vas broj je " + dobijeniBroj + "." + " Udaljenost od konacnog broja je: " + (trazeniBroj - dobijeniBroj) + ".";
                Label5.Text = Convert.ToString(dobijeniBroj);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
              CheckResults();
        }



        private void CheckResults()
        {
            if (TextBox1.Text.EndsWith("+"))
            {
                CurValue = TextBox1.Text;
                CurValue.TrimEnd('+');
            }
            if (TextBox1.Text.EndsWith("-"))
            {
                CurValue = TextBox1.Text;
                CurValue.TrimEnd('-');
            }
            if (TextBox1.Text.EndsWith("*"))
            {
                CurValue = TextBox1.Text;
                CurValue.TrimEnd('*');
            }
            if (TextBox1.Text.EndsWith("/"))
            {
                CurValue = TextBox1.Text;
                CurValue.TrimEnd('/');
            }

            if (String.IsNullOrEmpty(TextBox1.Text))
            {
                return;
            }
            else
            {
                try
                {
                    object result = resavac.Compute(TextBox1.Text, null);
                    dobijeniBroj = Convert.ToInt32(result);
                    if (dobijeniBroj == trazeniBroj)
                    {
                        Timer2.Stop();
                        btnPotvrdi.Enabled = false;
                        Done = true;
                        ShowingResults();
                    }
                    else
                    {
                        Label5.Text = Convert.ToString(dobijeniBroj);
                    }
                }
                catch (Exception)
                {

                    //throw;
                }
            }

                    
             
              }

        private void restartujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void aboutMojBorojToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int duzina;
            string str=TextBox1.Text;

            duzina = TextBox1.TextLength;
            if (str!="")
                str=str.Substring(0,duzina-1);
            TextBox1.Text = str;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        

        

        
        }
               


    }


      
