using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace c_winform
{
    public partial class Form1 : Form
    {
        //Для сотрудников
        string[] otch = { };
        string OtchetNaProverke = "Rak Kupil Piva\nНе надо дядя";
        List<List<string>> SotPas = new List<List<string>>
        {
            new List<string>() {"rab", "1234"},
            new List<string>() {"добрыня", "никитич"}
        };

        //Для админов
        string[] spisokSotrudnikov = {"rab1", "rab2"};
        string[] spisokTem = { "частушки Воркуты", "квазары", "кот в мешке", "боров Герца" };

        //Для руководителей
        string[,] SotTem = { { "rab1", "частушки Воркуты", "квазары", "кот в мешке", "боров Герца" }, { "rab2", "тема1", "тема2", "темы3", "тема4" } };
        List<List<string>> SotTem2 = new List<List<string>>
        {
            new List<string> { "rab1", "частушки Воркуты", "квазары", "кот в мешке", "боров Герца" },
            new List<string> { "rab2", "тема1", "тема2", "темы3", "тема4" }
        };

        public Form1()
        {
            InitializeComponent();
            buttonForRab.Hide();
            buttonOtchetNaProverke.Hide();

            buttonSotrAdd.Hide();
            buttonSotrDel.Hide();
            buttonTemAdd.Hide();
            buttonTemDel.Hide();

            buttonFindSotr.Hide();
            buttonDiscAdd.Hide();
            buttonDiscDel.Hide();
            buttonSeeOtch.Hide();
            buttonOtchErr.Hide();

            richTextBoxMain.Hide();
            richTextBoxMain2.Hide();
        }

        public void Test()
        {
            this.richTextBoxMain.Text = "абу";
            richTextBoxMain.Show();
            //this.Refresh();
            //richTextBoxMain.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Show();
            richTextBoxMain2.Show();
            string a = textBoxlogin.Text;
            string b = textBoxpassword.Text;

            for (int ii  = 0; ii < SotPas.Count; ii++)
            {
                if (textBoxlogin.Text == SotPas[ii][0] && textBoxpassword.Text == SotPas[ii][1])
                {
                    //конвертируем в int
                    //int a1 = Convert.ToInt32(a);
                    //int b1 = Convert.ToInt32(b);
                    //textBox1.Text = b1.ToString();


                    /*попробовать, если ошибка то catch
                    try{

                    }
                    catch (Exception err)
                    {
                        Console.WriteLine("{0} Exception.", err);
                    }
                    */

                    //Form2 newForm = new Form2();
                    //newForm.Show();

                    richTextBoxMain.Text = "Вы сотрудник\nТемы отчётов:\r\n";
                    foreach (string tema in spisokTem)
                    {
                        richTextBoxMain.Text += tema + " ";
                    }
                    richTextBoxMain2.Text = "Ваш отчёт:\n";
                    buttonForRab.Show();
                    buttonOtchetNaProverke.Show();
                }

                else if (textBoxlogin.Text == "admin" && textBoxpassword.Text == "крутой")
                {
                    richTextBoxMain.Text = "Если вы вдруг забыли, то работаете администратором\nСписок сотрудников:\n";
                    buttonSotrAdd.Show();
                    buttonSotrDel.Show();
                    buttonTemAdd.Show();
                    buttonTemDel.Show();

                    textBoxlogin.Text = "Введите логин сотрудника";
                    textBoxpassword.Text = "Введите название темы";

                    for (int i = 0; i < spisokSotrudnikov.Length; i++)
                    {
                        richTextBoxMain.Text += spisokSotrudnikov[i] + " ";
                    }

                    richTextBoxMain2.Text = "Список тем:\n";
                    foreach (string tem in spisokTem)
                    {
                        richTextBoxMain2.Text += tem + ", ";
                    }
                }
                else if (textBoxlogin.Text == "ruk" && textBoxpassword.Text == "ruk")
                {
                    buttonSeeOtch.Show();
                    buttonFindSotr.Show();
                    buttonDiscAdd.Show();
                    buttonDiscDel.Show();
                    buttonOtchErr.Show();
                    textBoxlogin.Text = "Введите логин сотрудника";
                    textBoxpassword.Text = "Введите название темы";
                    richTextBoxMain.Text = "Список сотрудников:\n";

                    for (int i = 0; i < SotTem2.Count; i++)
                    {
                        richTextBoxMain.Text += SotTem2[i][0] + " ";
                    }
                }
            }
            buttonSotAdd.Hide();
            button1.Hide();
        }

        //Для рабов
        private void buttonForRab_Click(object sender, EventArgs e)
        {
            Array.Resize(ref otch, otch.Length + 1);
            otch[otch.Length - 1] = richTextBoxMain2.Text;
        }

        private void buttonForExit(object sender, EventArgs e)
        {
            richTextBoxMain.Text = "";
            richTextBoxMain2.Text = "";
            buttonForRab.Hide();
            buttonOtchetNaProverke.Hide();
            textBoxlogin.Text = "Введите логин";
            textBoxpassword.Text = "Введите пароль";
            button1.Show();
            buttonSotAdd.Show();

            buttonSotrAdd.Hide();
            buttonSotrDel.Hide();
            buttonTemAdd.Hide();
            buttonTemDel.Hide();

            buttonDiscAdd.Hide();
            buttonDiscDel.Hide();
            buttonFindSotr.Hide();
            buttonOtchErr.Hide();
            buttonSeeOtch.Hide();

            richTextBoxMain.Hide();
            richTextBoxMain2.Hide();
        }

        private void buttonOtchetNaProverke_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Text = "Отчёт с ошибками:";
            richTextBoxMain2.Text = OtchetNaProverke;
        }


        //Для админов
        private void buttonSotrAdd_Click(object sender, EventArgs e)
        {
            Array.Resize(ref spisokSotrudnikov, spisokSotrudnikov.Length + 1);
            spisokSotrudnikov[spisokSotrudnikov.Length - 1] = textBoxlogin.Text;
            richTextBoxMain.Text += textBoxlogin.Text + " ";
        }

        private void buttonSotrDel_Click(object sender, EventArgs e)
        {
            Array.Resize(ref spisokSotrudnikov, spisokSotrudnikov.Length - 1);
            richTextBoxMain.Text = "Если вы вдруг забыли, то работаете администратором\nСписок сотрудников:\n";
            for (int i = 0; i < spisokSotrudnikov.Length; i++)
            {
                richTextBoxMain.Text += spisokSotrudnikov[i] + " ";
            }
        }

        private void buttonTemAdd_Click(object sender, EventArgs e)
        {
            Array.Resize(ref spisokTem, spisokTem.Length + 1);
            spisokTem[spisokTem.Length - 1] = textBoxlogin.Text;
            richTextBoxMain2.Text += textBoxlogin.Text + ", ";
        }

        private void buttonTemDel_Click(object sender, EventArgs e)
        {
            Array.Resize(ref spisokTem, spisokTem.Length - 1);
            richTextBoxMain2.Text = "Список тем:\n";
            foreach (string tem in spisokTem)
            {
                richTextBoxMain2.Text += tem + ", ";
            }
        }

        private void buttonFindSotr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SotTem2.Count; i++)
            {
                if (SotTem2[i][0] == textBoxlogin.Text)
                {
                    richTextBoxMain2.Text = "Сотрудник - " + SotTem2[i] [0] + "\nСписок его тем:\n";
                    for (int i2 = 1; i2 < SotTem2[i].Count; i2++)
                    {
                        richTextBoxMain2.Text += SotTem2[i][i2] + ", ";
                    }
                }
            }
        }

        private void buttonDiscAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SotTem2.Count; i++)
            {
                if (textBoxlogin.Text == SotTem2[i][0])
                {
                    SotTem2[i].Add(textBoxpassword.Text);
                    richTextBoxMain2.Text += textBoxpassword.Text + ", ";
                }
            }
        }

        private void buttonDiscDel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < SotTem2.Count; i++)
            {
                if (SotTem2[i][0] == textBoxlogin.Text)
                {
                    SotTem2[i].RemoveAt(SotTem2[i].Count - 1);
                    richTextBoxMain2.Text = "Сотрудник - " + SotTem2[i][0] + "\nСписок его тем:\n";
                    for (int i2 = 1; i2 < SotTem2[i].Count; i2++)
                    {
                        richTextBoxMain2.Text += SotTem2[i][i2] + ", ";
                    }
                }
            }
        }

        private void buttonSotAdd_Click(object sender, EventArgs e)
        {
            SotPas.Add(new List<string>{ textBoxlogin.Text, textBoxpassword.Text});
        }

        private void buttonSeeOtch_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Text += "Отчет сотрудника:";
            richTextBoxMain2.Text = otch[0];
        }
        
        private void buttonOtchErr_Click(object sender, EventArgs e)
        {
            OtchetNaProverke = richTextBoxMain2.Text;
        }
    }
}
