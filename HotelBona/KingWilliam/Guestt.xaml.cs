using KingWilliam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace KingWilliam
{
    /// <summary>
    /// Логика взаимодействия для Guest2.xaml
    /// </summary>
    public partial class Guestt : Window
    {
        string id = "";
        string type = "";
        string sql = "";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");

        public Guestt()
        {
            InitializeComponent();
        }
        public Guestt(string id, string type)
        {
                sql = "select serviceTransactionID as'Transaction ID', servicedescription as 'Description', servicedate as Date,amount as Amount from tblServicesTransactions inner join tblServices on tblServicesTransactions.ServiceID = tblServices.ServiceId where ReservationID = '" + 1 + "'";

                //sql = "select orderID as'Transaction ID', Transactiondate as Date,Cost as Amount from tblRestaurantTransactions where ReservationID = '" + 1 + "'";

            
            InitializeComponent();
            this.id = id;
            SqlCommand tr = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(tr); //c.con is the connection string

            DataTable dtRecord = new DataTable();
            dataAdapter.Fill(dtRecord);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GuestGrid.ItemsSource = AppData.db.tblGuests.ToList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEditGuest form = new AddEditGuest();
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GuestGrid.ItemsSource = AppData.db.tblGuests.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GuestInformation form = new GuestInformation();
            form.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Close();
        }

        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                GuestGrid.ItemsSource = AppData.db.tblGuests.Where(item => item.FirstName == Poisk.Text || item.FirstName.Contains(Poisk.Text) || item.GuestAddress.Contains(Poisk.Text) || item.LastName.Contains(Poisk.Text)).ToList();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            GuestGrid.ItemsSource = AppData.db.tblGuests.Where(item => item.PostalCode.Contains("Мужской")).ToList();
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            GuestGrid.ItemsSource = AppData.db.tblGuests.Where(item => item.PostalCode.Contains("Женский")).ToList();

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            GuestGrid.ItemsSource = AppData.db.tblGuests.ToList();
        }

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            GuestGrid.ItemsSource = AppData.db.tblGuests.ToList();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\Asus\Desktop\ПоНомерам.docx";

            // запускаем приложение Word и открываем файл
            Process.Start("WINWORD.EXE", filePath);
        }
    }
}
