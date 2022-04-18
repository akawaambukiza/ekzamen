using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace ekzamen
{
    public partial class ОсновнаяФорма : Form
    {
        int ff = 1;
        string connstr = @"Data Source=ngknn.ru;Initial Catalog = '44П КЭ РученинАА'; Persist Security Info=True;User ID = 44П;Password=H12TjtrV";
        public ОсновнаяФорма()
        {
            InitializeComponent();
            FillForm();
        }




        private void FillForm()
        {
            SqlCommand command;
            SqlConnection cmd = new SqlConnection(connstr);
            cmd.Open();
            command = cmd.CreateCommand();
            label17.Text = Convert.ToString(Program.count);
            label16.Text = Convert.ToString(Program.price);
            if (Program.count < 3)
            {
                label18.Visible = false;
                label8.Text = "0%";
            }
            else if ((Program.count >= 3) && (Program.count < 5))
            {
                label8.Text = "5%";
                Program.price = Convert.ToInt32(Convert.ToInt32(label16.Text) * 0.95);
                label18.Visible = true;
                label18.Text = Convert.ToString(Program.price);
            }

            else if ((Program.count >= 5) && (Program.count < 10))
            {
                label8.Text = "10%";
                Program.price = Convert.ToInt32(Convert.ToInt32(label16.Text) * 0.9);
                label18.Visible = true;
                label18.Text = Convert.ToString(Program.price);
            }

            else if ((Program.count >= 10))
            {
                label8.Text = "15%";
                Program.price = Convert.ToInt32(Convert.ToInt32(label16.Text) * 0.85);
                label18.Visible = true;
                label18.Text = Convert.ToString(Program.price);
            }

            if (ff == 1 )
            {
                command.CommandText = "select [Название] from Книги where id = 1";
                label1.Text = (string)command.ExecuteScalar();
                command.CommandText = "select [Жанр] from Книги where id = 1";
                label2.Text = (string)command.ExecuteScalar();
                command.CommandText = "select [Автор] from Книги where id = 1";
                label3.Text = (string)command.ExecuteScalar();
                label4.Text = "500";
                Bitmap img = new Bitmap("C:\\Users\\Akawa\\OneDrive\\Рабочий стол\\ekzamen\\ekzamen\\Covers\\Долгая прогулка.jpg");
                pictureBox1.Image = img;
                command.CommandText = "select [Количество_в_магазине] from Книги where id = 1";
                if (Convert.ToInt32(command.ExecuteScalar()) == 0) label5.Text = "Нет";
                else if (Convert.ToInt32(command.ExecuteScalar()) > 5) label5.Text = "Много";
                else label5.Text = Convert.ToString(command.ExecuteScalar());
                command.CommandText = "select [Количество_на_складе] from Книги where id = 1";
                if (Convert.ToInt32(command.ExecuteScalar()) == 0) label6.Text = "Нет";
                else if (Convert.ToInt32(command.ExecuteScalar()) > 5) label6.Text = "Много";
                else label6.Text = Convert.ToString(command.ExecuteScalar());
                label7.Text = "...Это была страшная игра – игра на выживание. Это была Долгая Прогулка.";


                command.CommandText = "select [Название] from Книги where id = 4";
                label15.Text = (string)command.ExecuteScalar();
                command.CommandText = "select [Жанр] from Книги where id = 4";
                label14.Text = (string)command.ExecuteScalar();
                command.CommandText = "select [Автор] from Книги where id = 4";
                label13.Text = (string)command.ExecuteScalar();
                label12.Text = "2300";
                Bitmap img2 = new Bitmap("C:\\Users\\Akawa\\OneDrive\\Рабочий стол\\ekzamen\\ekzamen\\Covers\\Мизери.jpg");
                pictureBox2.Image = img2;
                command.CommandText = "select [Количество_в_магазине] from Книги where id = 4";
                if (Convert.ToInt32(command.ExecuteScalar()) == 0) label11.Text = "Нет";
                else if (Convert.ToInt32(command.ExecuteScalar()) > 5) label11.Text = "Много";
                else label11.Text = Convert.ToString(command.ExecuteScalar());
                command.CommandText = "select [Количество_на_складе] from Книги where id = 4";
                if (Convert.ToInt32(command.ExecuteScalar()) == 0) label10.Text = "Нет";
                else if (Convert.ToInt32(command.ExecuteScalar()) > 5) label10.Text = "Много";
                else label10.Text = Convert.ToString(command.ExecuteScalar());
                label9.Text = "Может ли спасение от верной гибели обернуться таким кошмаром.";


                command.CommandText = "select [Название] from Книги where id = 9";
                label25.Text = (string)command.ExecuteScalar();
                command.CommandText = "select [Жанр] from Книги where id = 9";
                label24.Text = (string)command.ExecuteScalar();
                command.CommandText = "select [Автор] from Книги where id = 9";
                label23.Text = (string)command.ExecuteScalar();
                label22.Text = "325";
                Bitmap img3 = new Bitmap("C:\\Users\\Akawa\\OneDrive\\Рабочий стол\\ekzamen\\ekzamen\\Covers\\финист - ясный сокол.jpg");
                pictureBox4.Image = img3;
                command.CommandText = "select [Количество_в_магазине] from Книги where id = 9";
                if (Convert.ToInt32(command.ExecuteScalar()) == 0) label21.Text = "Нет";
                else if (Convert.ToInt32(command.ExecuteScalar()) > 5) label21.Text = "Много";
                else label21.Text = Convert.ToString(command.ExecuteScalar());
                command.CommandText = "select [Количество_на_складе] from Книги where id = 9";
                if (Convert.ToInt32(command.ExecuteScalar()) == 0) label20.Text = "Нет";
                else if (Convert.ToInt32(command.ExecuteScalar()) > 5) label20.Text = "Много";
                else label20.Text = Convert.ToString(command.ExecuteScalar());
                label19.Text = "Может ли спасение от верной гибели обернуться таким кошмаром.";


            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Корзина f = new Корзина();
            f.ShowDialog();
            FillForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.count++;
            Program.price += Convert.ToInt32(label4.Text);
            FillForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.count++;
            Program.price += Convert.ToInt32(label12.Text);
            FillForm();
        }

        private void БД_Click(object sender, EventArgs e)
        {
            БДФорма u = new БДФорма();
            u.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }

}

