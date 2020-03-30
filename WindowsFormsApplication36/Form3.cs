using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication36
{
    public partial class Form3 : Form
    {
        int sansayac, daksayac, sorusayac, sorusaysayac, rsayi1, k, rsayi2, harfsayac, rsayac, arapuan, tpuan, ysayac, sorusayacdis;
        int[] rsayidizi = new int[15];
        string kelime;
        bool durum;
        string[] sorular = new string[14];
        string[] cevaplar = new string[14];
        Random r = new Random();
        Label l = new Label();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false;
            label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
            label9.Visible = false; label10.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer1.Interval = 1000;
            timer2.Interval = 20;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            label18.Text = "04:00";
            durum = true;
            sorusayac = 0; sorusaysayac = 1; harfsayac = 0; sorusayacdis = 0;
            //label22.Text = "Soru  " + ((sorusayacdis + 1).ToString()) + "      :";
            //label23.Text = "Cevap  " + ((sorusayacdis + 1).ToString()) + "   :";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            try
            {
                if (durum == true)
                {
                    timer1.Enabled = true;
                }
                label11.Text = sorular[sorusayac];
                sorusayac++;
                durum = false;
                if (sorusaysayac == 1)
                {
                    kelime = cevaplar[0];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 400;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 2)
                {
                    kelime = cevaplar[1];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 400;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 3)
                {
                    kelime = cevaplar[2];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = false; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 500;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 4)
                {
                    kelime = cevaplar[3];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = false; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 500;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 5)
                {
                    kelime = cevaplar[4];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 600;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 6)
                {
                    kelime = cevaplar[5];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = false; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 600;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 7)
                {
                    kelime = cevaplar[6];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 700;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 8)
                {
                    kelime = cevaplar[7];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = false;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 700;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 9)
                {
                    kelime = cevaplar[8];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 800;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 10)
                {
                    kelime = cevaplar[9];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = false; label10.Visible = false;
                    arapuan = 800;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 11)
                {
                    kelime = cevaplar[10];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = true; label10.Visible = false;
                    arapuan = 900;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 12)
                {
                    kelime = cevaplar[11];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = true; label10.Visible = false;
                    arapuan = 900;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                }
                if (sorusaysayac == 13)
                {
                    kelime = cevaplar[12];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;//Daha fazla bilgi için : www.gorselprogramlama.com
                    label9.Visible = true; label10.Visible = true;
                    arapuan = 1000;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();

                }
                if (sorusaysayac == 14)
                {
                    kelime = cevaplar[13];
                    label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true;
                    label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;
                    label9.Visible = true; label10.Visible = true;
                    arapuan = 1000;
                    label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                    MessageBox.Show("Puanınız= " + tpuan.ToString());


                }
                sorusaysayac++;
                if (sorusaysayac < 15)
                {

                    button3.Text = "Soru " + sorusaysayac;
                }
                else
                {
                    button3.Text = "Başla";

                    button3.Enabled = false;

                }//
                harfsayac = 0;
                label1.Text = "___";
                label2.Text = "___";
                label3.Text = "___";
                label4.Text = "___";
                label5.Text = "___";
                label6.Text = "___";
                label7.Text = "___";
                label8.Text = "___";
                label9.Text = "___";
                label10.Text = "___";
                button1.Enabled = true;
                button2.Enabled = true;

                Array.Clear(rsayidizi, 0, (rsayidizi.Length));
            }
            catch
            {
                ;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sansayac++;
            if (sansayac > 50)
            {
                label18.Text = "0" + (3 - daksayac).ToString() + " : 0" + (60 - sansayac).ToString();
            }
            else
            {
                label18.Text = "0" + (3 - daksayac).ToString() + " : " + (60 - sansayac).ToString();//Daha fazla bilgi için : www.gorselprogramlama.com
            }


            if (sansayac == 60)
            {
                daksayac++;
                sansayac = 0;
            }
            if (daksayac == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                timer1.Enabled = false;
            }   //     
        }
        private void button1_Click(object sender, EventArgs e)
        {

            rsayac = 0;
            harfsayac++;
            switch (sorusayac)
            {
                case 1:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[0];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(5);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 4)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }

                        break;

                    }
                case 2:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[1];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(5);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 4)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }

                        break;

                    }
                case 3:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[2];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(6);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 5)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 4:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[3];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(6);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 5)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 5:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[4];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(7);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 6)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 6:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[5];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(7);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 6)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 7:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[6];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(8);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 7)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 8:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[7];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(8);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 7)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 9:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[8];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(9);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 8)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 10:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[9];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(9);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 8)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 11:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[10];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(10);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 9)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 12:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[11];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(10);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 9)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 13:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[12];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(11);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 10)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                        }
                        break;

                    }
                case 14:
                    {
                        arapuan -= 100;
                        label16.Text = tpuan.ToString() + "  /  " + arapuan.ToString();
                        kelime = cevaplar[13];
                        while (rsayac == 0)
                        {
                            rsayi1 = r.Next(11);
                            if (Array.IndexOf(rsayidizi, rsayi1) == -1)
                            {
                                rsayidizi[harfsayac] = rsayi1;
                                rsayac++;
                                ysayac++;
                            }
                        }
                        timer2.Enabled = true;
                        if (ysayac == 10)
                        {
                            ysayac = 0;
                            button1.Enabled = false;
                            timer1.Enabled = false;
                        }

                        break;

                    }


            }





        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                switch (rsayi1)
                {
                    case 1:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label1.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label1.Text = kelime[0].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }

                        break;
                    case 2:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label2.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label2.Text = kelime[1].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 3:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label3.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label3.Text = kelime[2].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 4:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label4.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label4.Text = kelime[3].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 5:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label5.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label5.Text = kelime[4].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 6:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label6.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label6.Text = kelime[5].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 7:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label7.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label7.Text = kelime[6].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 8:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label8.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label8.Text = kelime[7].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 9:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label9.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label9.Text = kelime[8].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    case 10:
                        if (k < 25)
                        {
                            rsayi2 = r.Next(65, 91);
                            label10.Text = ((char)rsayi2).ToString();
                            k++;
                            button1.Enabled = false;
                        }
                        else
                        {
                            timer2.Enabled = false;
                            label10.Text = kelime[9].ToString();
                            k = 0;
                            button1.Enabled = true;
                        }
                        break;
                    default:
                        MessageBox.Show("Hata");
                        break;
                }
            }
            catch
            {
                ;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            switch (sorusayac)
            {
                case 1:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[0])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        break;
                    }
                case 2:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[1])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        break;
                    }
                case 3:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[2])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString();
                        break;
                    }
                case 4:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[3])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString();
                        break;
                    }
                case 5:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[4])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        break;
                    }
                case 6:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[5])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        break;
                    }
                case 7:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[6])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString();
                        break;
                    }
                case 8:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[7])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString();
                        break;
                    }
                case 9:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[8])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        break;
                    }
                case 10:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[9])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        break;
                    }
                case 11:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[10])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        label9.Text = kelime[8].ToString();
                        break;
                    }
                case 12:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[11])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        label9.Text = kelime[8].ToString();
                        break;
                    }
                case 13:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[12])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        label9.Text = kelime[8].ToString(); label10.Text = kelime[9].ToString();
                        break;
                    }
                case 14:
                    {
                        if (textBox1.Text.ToUpper() == cevaplar[13])
                            tpuan += arapuan;
                        else
                            tpuan -= arapuan;
                        label16.Text = tpuan.ToString() + "  /  " + "0";
                        label1.Text = kelime[0].ToString(); label2.Text = kelime[1].ToString();
                        label3.Text = kelime[2].ToString(); label4.Text = kelime[3].ToString();
                        label5.Text = kelime[4].ToString(); label6.Text = kelime[5].ToString();
                        label7.Text = kelime[6].ToString(); label8.Text = kelime[7].ToString();
                        label9.Text = kelime[8].ToString(); label10.Text = kelime[9].ToString();
                        timer1.Enabled = false;
                        break;
                    }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            durum = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            switch (sorusayacdis)
            {
                case 0:
                case 1:
                    {
                        if (textBox3.Text.Length != 4) MessageBox.Show("Cevabınız dört harfli olmalı");
                        else
                        {
                            sorular[sorusayacdis] = textBox2.Text.ToUpper();
                            cevaplar[sorusayacdis] = textBox3.Text.ToUpper();
                            sorusayacdis++;
                        }
                        break;
                    }
                case 2:
                case 3:
                    {
                        if (textBox3.Text.Length != 5) MessageBox.Show("Cevabınız beş harfli olmalı");//Daha fazla bilgi için : www.gorselprogramlama.com
                        else
                        {
                            sorular[sorusayacdis] = textBox2.Text.ToUpper();
                            cevaplar[sorusayacdis] = textBox3.Text.ToUpper();
                            sorusayacdis++;
                        }
                        break;
                    }
                case 4:
                case 5:
                    {
                        if (textBox3.Text.Length != 6) MessageBox.Show("Cevabınız altı harfli olmalı");
                        else
                        {
                            sorular[sorusayacdis] = textBox2.Text.ToUpper();
                            cevaplar[sorusayacdis] = textBox3.Text.ToUpper();
                            sorusayacdis++;
                        }
                        break;
                    }
                case 6:
                case 7:
                    {
                        if (textBox3.Text.Length != 7) MessageBox.Show("Cevabınız yedi harfli olmalı");
                        else
                        {
                            sorular[sorusayacdis] = textBox2.Text.ToUpper();
                            cevaplar[sorusayacdis] = textBox3.Text.ToUpper();
                            sorusayacdis++;
                        }
                        break;
                    }
                case 8:
                case 9:
                    {
                        if (textBox3.Text.Length != 8) MessageBox.Show("Cevabınız sekiz harfli olmalı");
                        else
                        {
                            sorular[sorusayacdis] = textBox2.Text.ToUpper();
                            cevaplar[sorusayacdis] = textBox3.Text.ToUpper();
                            sorusayacdis++;
                        }
                        break;
                    }
                case 10:
                case 11:
                    {
                        if (textBox3.Text.Length != 9) MessageBox.Show("Cevabınız dokuz harfli olmalı");
                        else
                        {
                            sorular[sorusayacdis] = textBox2.Text.ToUpper();
                            cevaplar[sorusayacdis] = textBox3.Text.ToUpper();
                            sorusayacdis++;
                        }
                        break;
                    }
                case 12:
                case 13:
                    {
                        if (textBox3.Text.Length != 10) MessageBox.Show("Cevabınız on harfli olmalı");
                        else
                        {
                            sorular[sorusayacdis] = textBox2.Text.ToUpper();
                            cevaplar[sorusayacdis] = textBox3.Text.ToUpper();
                            sorusayacdis++;
                        }
                        break;
                    }
                default:
                    button5.Enabled = false;
                    break;

            }
            if (sorusayacdis < 14)
            {
                label22.Text = "Soru  " + ((sorusayacdis + 1).ToString()) + "      :";
                label23.Text = "Cevap  " + ((sorusayacdis + 1).ToString()) + "   :";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sansayac = 0; daksayac = 0; tpuan = 0; arapuan = 0;
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Text = "Başla";
            durum = true;
            sorusayac = 0; sorusaysayac = 1; harfsayac = 0; sorusayacdis = 0;
            button3.Enabled = true;
            label24.Text = "1. YARIŞMACI ";
            sorular[0] = "1- Trafikte hazır olmaya yarayan lambanın rengi";
            cevaplar[0] = "SARI";
            sorular[1] = "2- Trafikte taşıt kullanmayan kişi";
            cevaplar[1] = "YAYA";
            sorular[2] = "3- Araçlarn hareket ettirmeye yarayan mekanizma";
            cevaplar[2] = "MOTOR";
            sorular[3] = "4- Arabanın hızlı veya yavaş gitmesini sağlayan araç";
            cevaplar[3] = "VİTES";
            sorular[4] = "5- Dönüş yaptığımız yuvarlak yol";
            cevaplar[4] = "KAVŞAK";
            sorular[5] = "6- Araçların dönerken diğer araçlara verdiği işaret ";
            cevaplar[5] = "SİNYAL";
            sorular[6] = "7- Yolarda güvenliği sağlayan kurum";
            cevaplar[6] = "EMNİYET";
            sorular[7] = "8- Genellikle köylerde olup yük taşımaya yarayan araç";
            cevaplar[7] = "TRAKTÖR";
            sorular[8] = "9- Ana yollarda yayaların geçmesi için yapılan köprü ";
            cevaplar[8] = "ÜSTGEÇİT";
            sorular[9] = "10-Arabanın diğer adı ";
            cevaplar[9] = "OTOMOBİL";
            sorular[10] = "11-Gemilerin kullandığı yol ";
            cevaplar[10] = "DENİZYOLU";
            sorular[11] = "12-Kaza durumunda hastaya yapılan ilk müdahale";
            cevaplar[11] = "İLKYARDIM";
            sorular[12] = "13- Yayayların geçmesi için asfaltta bulunun çizgili yollar";
            cevaplar[12] = "YAYAGEÇİDİ";
            sorular[13] = "14-İki tekerlekli motorlu araç";
            cevaplar[13] = "MOTOSİKLET";


        }
        private void button7_Click(object sender, EventArgs e)
        {
            sansayac = 0; daksayac = 0; tpuan = 0; arapuan = 0;
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Text = "Başla";
            durum = true;
            sorusayac = 0; sorusaysayac = 1; harfsayac = 0; sorusayacdis = 0;
            button3.Enabled = true;
            label24.Text = "2. YARIŞMACI ";
            sorular[0] = "1- Trafikteki taşıtlar";
            cevaplar[0] = "ARAÇ";
            sorular[1] = "2- Demiryolu tasımacılığı yapan araç";
            cevaplar[1] = "TREN";
            sorular[2] = "3- Trafik ışıklarında geç komutunu gösteren ışık";
            cevaplar[2] = "YEŞİL";
            sorular[3] = "4- Trafikteki araçlar";
            cevaplar[3] = "TAŞIT";
            sorular[4] = "5-ulaşım yollarının yayalarca ve her türlü taşıtlarca kullanılması. ";
            cevaplar[4] = "TRAFİK";
            sorular[5] = "6- Genellikle şehirler arası yük taşımacılığı yapan büyük araç";
            cevaplar[5] = "KAMYON";
            sorular[6] = "7- Trafikte öndeki aracı geçme";
            cevaplar[6] = "SOLLAMA";
            sorular[7] = "8- Sürücülere araç sürmese yetkisini veren belge";
            cevaplar[7] = "EHLİYET";
            sorular[8] = "9- Anayollarda yayaların geçmesi için yapılan yerın altından tünel";
            cevaplar[8] = "ALTGEÇİT";
            sorular[9] = "10- Araba ,kamyon gibi taşıtların kullandığı yol";
            cevaplar[9] = "KARAYOLU";
            sorular[10] = "11-Trenin kullandığı yol";
            cevaplar[10] = "DEMİRYOLU";
            sorular[11] = "12- levhalarda ünlem işaretinin anlamı";
            cevaplar[11] = "TEHLİKELİ";
            sorular[12] = "13- Okullanrın yakınında öğrenvcilerin karsıdan karsıya geçmesi için kullanılan yol";
            cevaplar[12] = "OKULGEÇİDİ";
            sorular[13] = "14-Arabaya yön vermeye yarayan yuvarlak alet";
            cevaplar[13] = "DİREKSİYON";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sansayac = 0; daksayac = 0; tpuan = 0; arapuan = 0;
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Text = "Başla";
            durum = true;
            sorusayac = 0; sorusaysayac = 1; harfsayac = 0; sorusayacdis = 0;
            button3.Enabled = true;
            label24.Text = "3. YARIŞMACI ";
            sorular[0] = "1- Akşamları yolu görmemizi saglayan şey(far)";
            cevaplar[0] = "IŞIK";
            sorular[1] = "2- Deniz taşımacılığı yapan taşıt";
            cevaplar[1] = "GEMİ";
            sorular[2] = "3- Taşıtları birbirinden ayırmak için kullanılan metal yapı";
            cevaplar[2] = "PLAKA";
            sorular[3] = "4- Hız";
            cevaplar[3] = "SÜRAT";
            sorular[4] = "5-Şehirler arası toplu insan taşıma aracı";
            cevaplar[4] = "OTOBÜS";
            sorular[5] = "6- Araçta 4 tane bulunan gitmesini sağlayan plastik yapı";
            cevaplar[5] = "LASTİK";
            sorular[6] = "7- Dur ifade eden ışık";
            cevaplar[6] = "KIRMIZI";
            sorular[7] = "8- Trafik levhalarında mavi zemin üzerinde h hafi ne anlama gelir";
            cevaplar[7] = "HASTANE";
            sorular[8] = "9- İki tekerli çoçuk tasıtı";
            cevaplar[8] = "BİSİKLET";
            sorular[9] = "10- Uçakların kullandığı yol";
            cevaplar[9] = "HAVAYOLU";
            sorular[10] = "11- Karayolunda yolların ortasında olan beyaz çizgi";
            cevaplar[10] = "YOLŞERİDİ";
            sorular[11] = "12-Kaza durumunda hastaya yapılan ilk müdahale ";
            cevaplar[11] = "İLKYARDIM";
            sorular[12] = "13-Kara yolu ve demiryolunun birleştiği yol(hemgeçit zemin)";
            cevaplar[12] = "TRENGEÇİDİ";
            sorular[13] = "14- Öğrencileri okula götüren araç ";
            cevaplar[13] = "OKULTAŞITI";
        }

        private void button9_Click(object sender, EventArgs e)
        {/*
           sansayac = 0; daksayac = 0; tpuan = 0; arapuan = 0;
           timer1.Enabled = false;
           button1.Enabled = false;
           button2.Enabled = false;
           button3.Text = "Başla";
           durum = true;
           sorusayac = 0; sorusaysayac = 1; harfsayac = 0; sorusayacdis = 0;
           button3.Enabled = true;
           label24.Text = "4. YARIŞMACI ";
           sorular[0] = "1- Askerlik ödevini yapmaya çağırma";
           cevaplar[0] = "CELP";
           sorular[1] = "2- Sonu gelmeyen istek, aşırı tutku";
           cevaplar[1] = "HIRS";
           sorular[2] = "3- Zararı az, en zararsız";
           cevaplar[2] = "EHVEN";
           sorular[3] = "4- Çıkıntıları çok olan bitki";
           cevaplar[3] = "DİKEN";
           sorular[4] = "5- Alacak ve verecekleri hesaplayarak sonucu belirlenmiş";
           cevaplar[4] = "LİKİDE";
           sorular[5] = "6- Tamamıyla, büsbütün";
           cevaplar[5] = "HEPTEN";
           sorular[6] = "7- Tasalanmış, tasalı, kaygılı";
           cevaplar[6] = "EFKARLI";
           sorular[7] = "8- Sert ve sürekli çıkan ses";
           cevaplar[7] = "HIŞILTI";
           sorular[8] = "9- Görür görmez seven, âşık olan kimse";
           cevaplar[8] = "ŞIPSEVDİ";
           sorular[9] = "10- Çıkış yeri kolay bulunamayacak kadar karışık koridorları olan yapı";
           cevaplar[9] = "LABİRENT";
           sorular[10] = "11- Çok kazanmak";
           cevaplar[10] = "PARAKIRMAK";
           sorular[11] = "12- bir şey yapmak için onay sağlamak";
           cevaplar[11] = "İZİNALMAK";
           sorular[12] = "13- Bir aşağı bir yukarı dolaşmak";
           cevaplar[12] = "VOLTAATMAK";
           sorular[13] = "14- Sürekli ve hızlı bir biçimde";
           cevaplar[13] = "BICIRBICIR";*/
        }

        private void button10_Click(object sender, EventArgs e)
        {/*
           sansayac = 0; daksayac = 0; tpuan = 0; arapuan = 0;
           timer1.Enabled = false;
           button1.Enabled = false;
           button2.Enabled = false;
           button3.Text = "Başla";
           durum = true;
           sorusayac = 0; sorusaysayac = 1; harfsayac = 0; sorusayacdis = 0;
           button3.Enabled = true;
           label24.Text = "5. YARIŞMACI ";
           sorular[0] = "1- Gücü bir işe yetmez olanın durumu, güçsüzlük";
           cevaplar[0] = "ACİZ";
           sorular[1] = "2- Kaçak ve yasak şeylerin saklandığı gizli yer";
           cevaplar[1] = "ZULA";
           sorular[2] = "3- Keten, kenevir gibi türlü dokuma maddelerinden yapılan ince halat";
           cevaplar[2] = "URGAN";
           sorular[3] = "4- Geçimsizlik, anlaşmazlık, ara bozuculuk";
           cevaplar[3] = "NİFAK";
           sorular[4] = "5- Belirli bir sebebi olmadan sinirlenip huysuzluk eden (kimse)";
           cevaplar[4] = "HIRÇIN";
           sorular[5] = "6- İstenilen düzende olan, düzene uygun olan, kurallara uygun olan";
           cevaplar[5] = "NİZAMİ";
           sorular[6] = "7- Değişik iş kollarında gerekli olan şeyler, araç ve gereçler";
           cevaplar[6] = "LEVAZIM";
           sorular[7] = "8- Sertlik, kabalık, kırıcılık";
           cevaplar[7] = "HUŞUNET";
           sorular[8] = "9- Bir elektrik üretecinin kutuplarını birbirinden ayırt etmeyi sağlayan nitelik";
           cevaplar[8] = "POLARİTE";
           sorular[9] = "10- Türlü eğlence ve oyun kuruluşları bulunan alan";
           cevaplar[9] = "LUNAPARK";
           sorular[10] = "11- Alışılmış olandan ayrı, olağanüstü, beklenmedik, görülmedik, işitilmedik";
           cevaplar[10] = "FEVKALADE";
           sorular[11] = "12- Kötü bir davranışa aynen verilen karşılık";
           cevaplar[11] = "MİSİLLEME";
           sorular[12] = "13- Bir isteği kabul etmeme, nazlanma";
           cevaplar[12] = "MIRINKIRIN";
           sorular[13] = "14- Eşi görülmemiş, şaşkınlık yaratıcı, olağanüstü";
           cevaplar[13] = "HARİKULADE";*/
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

    }
}

