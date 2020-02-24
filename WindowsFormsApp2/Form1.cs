using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }
        string cıktı=null;
        string cıktı1 = null;
        string cıktı2 = null;
        string cıktı3 = null;
        string cıktı4 = null;
        double tutar;
        private void button1_ekle_Click(object sender, EventArgs e)
        {
           
            if(checkBox1_syhbyz.Checked == true)
            {
                cıktı = "SİYAH-BEYAZ";

            }
            else if(checkBox2_rnk.Checked == true) 
            {
                cıktı = "RENKLİ";
            }
       
            if (checkBox13_tekyön.Checked == true)
            {
                cıktı1 = "TEK YÖN";

            }
            else if(checkBox14_önarka.Checked == true)
            {
                cıktı1 = "ÖN-ARKA";
            }
           
            if (checkBox3_isteslim.Checked == true)
            {
                cıktı2 = "İŞYERİ TESLİM";

            }
            else if(checkBox4_kargo.Checked == true)
            {
                cıktı2 = "KARGO";
            }
            if (checkBox5_spiral.Checked == true)
            {
                cıktı3 = "HELEZON SPİRAL";

            }
            else if(checkBox6_karton.Checked == true)
            {
                cıktı3 = "KARTON CİLT";
            }
            if (checkBox8_a4.Checked == true)
            {
                cıktı4 = "A4";

            }
            else if(checkBox7_a5.Checked == true)
            {
                cıktı4 = "A5";
            }
            else if(checkBox9_a3.Checked == true)
            {
                cıktı4 = "A3";
            }
            if(checkBox9_a3.Checked == true)
            {
                if(checkBox1_syhbyz.Checked == true)
                {
                    if(checkBox13_tekyön.Checked == true)
                    {
                        if(checkBox3_isteslim.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.25;
                        }
                        else
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.30;
                        }
                    }
                    else
                    {
                        if (checkBox3_isteslim.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.30;
                        }
                        else
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.35;
                        }
                    }
                }
                else
                {
                    if (checkBox13_tekyön.Checked == true)
                    {
                        if(checkBox10_std80.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 1.00;

                        }
                        else if(checkBox17_prlk130.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 1.25;

                        }
                        else if(checkBox16_prlk170.Checked == true || checkBox11_mat170.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 1.50;

                        }
                        else if(checkBox12_prlk300.Checked == true || checkBox15_mat300.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 2.00;

                        }
                    }
                    else
                    {
                        if (checkBox10_std80.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 2.00;

                        }
                        else if (checkBox17_prlk130.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 2.50;

                        }
                        else if (checkBox16_prlk170.Checked == true || checkBox11_mat170.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 3.00;

                        }
                        else if (checkBox12_prlk300.Checked == true || checkBox15_mat300.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 4.00 ;

                        }
                    }
                }
            }
            else if(checkBox7_a5.Checked == true)
            {
                if (checkBox1_syhbyz.Checked == true)
                {
                    if (checkBox13_tekyön.Checked == true)
                    {
                        if (checkBox3_isteslim.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.06;
                        }
                        else
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.07;
                        }
                    }
                    else
                    {
                        if (checkBox3_isteslim.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.06;
                        }
                        else
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.08;
                        }
                    }
                }
                else
                {
                    if (checkBox13_tekyön.Checked == true)
                    {
                        if (checkBox10_std80.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.35;

                        }
                        else if (checkBox17_prlk130.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.50;

                        }
                        else if (checkBox16_prlk170.Checked == true || checkBox11_mat170.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.60;

                        }
                        else if (checkBox12_prlk300.Checked == true || checkBox15_mat300.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.75;

                        }
                    }
                    else
                    {
                        if (checkBox10_std80.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 0.70;

                        }
                        else if (checkBox17_prlk130.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 1.00;

                        }
                        else if (checkBox16_prlk170.Checked == true || checkBox11_mat170.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 1.30;

                        }
                        else if (checkBox12_prlk300.Checked == true || checkBox15_mat300.Checked == true)
                        {
                            tutar = Convert.ToDouble(textBox2_syfsayısı.Text) * 1.50;

                        }
                    }
                }
                if(checkBox5_spiral.Checked == true)
                {
                    if (Convert.ToInt32(textBox2_syfsayısı.Text) < 101)
                    {
                        tutar += 3.00;
                    }
                    else if (Convert.ToInt32(textBox2_syfsayısı.Text) < 201)
                    {
                        tutar += 3.50;
                    }
                    else if (Convert.ToInt32(textBox2_syfsayısı.Text) < 301)
                    {
                        tutar += 4.00;
                    }
                    else if (Convert.ToInt32(textBox2_syfsayısı.Text) < 401)
                    {
                        tutar += 4.50;
                    }
                    else if (Convert.ToInt32(textBox2_syfsayısı.Text) < 501)
                    {
                        tutar += 5.00;
                    }

                    if(checkBox6_karton.Checked == true)
                    {
                        tutar += 10.00;

                    }
                }
            }
  
            dataGridView1.Rows.Add(textBox1_dosyaism.Text.ToString().TrimEnd(), cıktı, cıktı1, cıktı2, cıktı3, cıktı4, textBox2_syfsayısı.Text.ToString().TrimEnd(),tutar.ToString());

            
        }

        private void checkBox1_syhbyz_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox2_rnk.Enabled = false;
            checkBox10_std80.Checked = true;
            if (checkBox1_syhbyz.Checked == false)
            {
                checkBox2_rnk.Enabled = true;
                checkBox10_std80.Checked = false;
                checkBox15_mat300.Enabled = true;
                checkBox11_mat170.Enabled = true;
                checkBox12_prlk300.Enabled = true;
                checkBox16_prlk170.Enabled = true;
                checkBox17_prlk130.Enabled = true;

            }

            if (checkBox1_syhbyz.Checked == true)
            {
                checkBox15_mat300.Enabled = false;
                checkBox11_mat170.Enabled = false;
                checkBox12_prlk300.Enabled = false;
                checkBox16_prlk170.Enabled = false;
                checkBox17_prlk130.Enabled = false;
            }
           
        }

        private void checkBox2_rnk_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox1_syhbyz.Enabled = false;
            if (checkBox2_rnk.Checked == false)
            {
                checkBox1_syhbyz.Enabled = true;

            }
        }

        private void checkBox9_a3_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox5_spiral.Enabled = false;
            checkBox6_karton.Enabled = false;
            checkBox8_a4.Enabled = false;
            checkBox7_a5.Enabled = false;
            if (checkBox9_a3.Checked == false)
            {
                checkBox5_spiral.Enabled = true;
                checkBox6_karton.Enabled = true;
                checkBox8_a4.Enabled = true;
                checkBox7_a5.Enabled = true;
            }


        }

        private void checkBox13_tekyön_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox14_önarka.Enabled = false;
            if(checkBox13_tekyön.Checked == false)
            {
                checkBox14_önarka.Enabled = true;

            }
        }

        private void checkBox14_önarka_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox13_tekyön.Enabled = false;
            if (checkBox14_önarka.Checked == false)
            {
                checkBox13_tekyön.Enabled = true;

            }
        }

        private void checkBox7_a5_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox8_a4.Enabled = false;
            checkBox9_a3.Enabled = false;
            if (checkBox7_a5.Checked == false)
            {
       
                checkBox8_a4.Enabled = true;
                checkBox9_a3.Enabled = true;
            }
        }

        private void checkBox8_a4_MouseClick(object sender, MouseEventArgs e)
        {
            checkBox7_a5.Enabled = false;
            checkBox9_a3.Enabled = false;
            if (checkBox8_a4.Checked == false)
            {

                checkBox7_a5.Enabled = true;
                checkBox9_a3.Enabled = true;
            }
        }

        private void checkBox13_tekyön_MouseClick_1(object sender, MouseEventArgs e)
        {
            checkBox14_önarka.Enabled = false;
            if(checkBox13_tekyön.Checked == false)
            {
                checkBox14_önarka.Enabled = true;
            }
        }

        private void checkBox14_önarka_MouseClick_1(object sender, MouseEventArgs e)
        {
            checkBox13_tekyön.Enabled = false;
            if (checkBox14_önarka.Checked == false)
            {
                checkBox13_tekyön.Enabled = true;
            }
        }
    }
}
