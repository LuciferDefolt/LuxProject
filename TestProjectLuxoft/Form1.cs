using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestProjectLuxoft
{
    public partial class Form1 : Form
    {
        private int ListLength = 0;
        private int Page = 1;
        private string PersonName = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //узнаю общее колличество строк чтобы разбить на страницы
            MySqlConnection connection = DBUtils.GetDBConnection();
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "Select * from List";
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    ListLength++;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error pls restart");
            }
            finally
            {
                connection.Close();
            }
            //Вывод первого элемента
            PersonShow(1);
        }

        private void PersonShow(int number)
        {
            MySqlConnection connection = DBUtils.GetDBConnection();
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "Select * from List WHERE id='"+number+"'";
                MySqlDataReader mySqlDataReader = command.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    PersonNameField.Text = mySqlDataReader["PersonName"].ToString().ToString();
                    PersonName = mySqlDataReader["PersonName"].ToString().ToString();
                    PersonNumberField.Text = mySqlDataReader["PersonNumber"].ToString().ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error pls restart");
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Page != ListLength)
            {
                Page++;
                PersonShow(Page);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Page != 1)
            {
                Page--;
                PersonShow(Page);
            }
        }

        private void CallNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PersonName + " is calling");
        }
    }
}
