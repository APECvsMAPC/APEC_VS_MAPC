using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;


namespace Pyaterochka
{
    public partial class Form1 : Form
    {
        public static string connString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = 'Database.mdb'";
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string name1 = name.Text;
            string name2 = textBox2.Text;
            int name3 = Convert.ToInt32(textBox3.Text);
            string name4 = textBox4.Text;
            string name5 = textBox5.Text;
            string pol;
            if (name1 == "")
            {
                MessageBox.Show("Введите имя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!proverka_name(name1))
            {
                MessageBox.Show("Имя некорректно. Оно должно начинаться с большой буквы и содержать только русские буквы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name2 == "")
            {
                MessageBox.Show("Введите название товара.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name3 <= 0)
            {
                MessageBox.Show("Количество товара должно быть больше нуля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!proverka_tel(name4))
            {
                MessageBox.Show("Номер телефона некорректен. Он должен быть вида +7(xxx)XXX-XX-XX/8(XXX)XXX-XX-XX.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!proverka_mail(name5))
            {
                MessageBox.Show("Почта некорректна. Она должна быть вида example@example.ru .", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!men.Checked && !girl.Checked)
            {
                MessageBox.Show("Укажите ваш пол.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(connString);
                conn.Open();
                String sql = "INSERT INTO tbl_zakazov (name, tovar, kolv, tel, mail, pol) VALUES (n, t, k, te, m, p)";
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("n", name1);
                cmd.Parameters.AddWithValue("t", name2);
                cmd.Parameters.AddWithValue("k", name3);
                cmd.Parameters.AddWithValue("te", name4);
                cmd.Parameters.AddWithValue("m", name5);
                if (men.Checked)
                {
                    pol = "Мужской";
                }
                else
                {
                    pol = "Женский";
                }
                cmd.Parameters.AddWithValue("p", pol);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");
                cmd.Dispose();
                conn.Close();
            }
        }
        static bool proverka_name(string name)
        {
            string pattern = @"^[А-ЯЁ][а-яё]+$";
            return Regex.IsMatch(name, pattern);
        }
        static bool proverka_tel(string tel)
        {
            string pattern = @"^(?:\+7|8)\s*(\(\d{3}\)|\d{3})\s*\d{3}[- ]?\d{2}[- ]?\d{2}$";
            return Regex.IsMatch(tel, pattern);
        }
        static bool proverka_mail(string mail)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(mail, pattern);
        }
    }
}
