using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace homework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection connection;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            string fulltable = @"SELECT AVG(Colories) FROM FruitAndVegetabless";
            SqlCommand command = new SqlCommand(fulltable, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    output.Text += sqlDataReader[i] + "\t";
                }
                output.Text += "\n";
            }
            sqlDataReader.Close();
        }
    

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Homeworkkk;Integrated Security=SSPI;");
                connection.Open();
                ConnectionText.Text = "";
                ConnectionText.Text = "Подключение установлено";
            }
            catch
            {
                ConnectionText.Text = " ";
                ConnectionText.Text = "Ошибка подключения к серверу";
                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Close();
                ConnectionText.Text = " ";
                ConnectionText.Text = "Сервер отключен";
                

            }
            catch
            {
                ConnectionText.Text = " ";
                ConnectionText.Text = "Ошибка отключения к серверу";
                
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            output.Text = "";
            string fulltable = @"SELECT*FROM FruitAndVegetabless";
            SqlCommand command = new SqlCommand(fulltable, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    output.Text += sqlDataReader[i] + "\t";
                }
                output.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            string fulltable = @"SELECT Name FROM FruitAndVegetabless";
            SqlCommand command = new SqlCommand(fulltable, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    output.Text += sqlDataReader[i] + "\t";
                }
                output.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            string fulltable = @"SELECT Colour FROM FruitAndVegetabless";
            SqlCommand command = new SqlCommand(fulltable, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    output.Text += sqlDataReader[i] + "\t";
                }
                output.Text += "\n";
            }
            sqlDataReader.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            output.Text = "";
            string fulltable = @"SELECT Max(Colories) FROM FruitAndVegetabless";
            SqlCommand command = new SqlCommand(fulltable, connection);
            SqlDataReader sqlDataReader = command.ExecuteReader();
            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    output.Text += sqlDataReader[i] + "\t";
                }
                output.Text += "\n";
            }
            sqlDataReader.Close();

        }
    }
    }
    

