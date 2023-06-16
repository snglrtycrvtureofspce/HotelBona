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
using KingWilliam.Model;
using System.Drawing;
using System.Data.Entity;

namespace KingWilliam
{
    /// <summary>
    /// Логика взаимодействия для Reserv.xaml
    /// </summary>
    public partial class Reserv : Window
    {
        string id = "";
        string type = "";
        string sql = "";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");

        public Reserv()
        {
            InitializeComponent();
        }
        public Reserv(string id, string type)
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

        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            GuestGrid.ItemsSource = AppData.db.tblReservations.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExistingReservation form = new ExistingReservation();
            form.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                GuestGrid.ItemsSource = AppData.db.tblReservations.Where(item => item.RoomID.Contains(Poisk.Text)).ToList();
                
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            GuestGrid.ItemsSource = AppData.db.tblReservations.Where(item => item.RoomID.Contains(Poisk.Text)).ToList();
        }


        private void dated_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
 
            // Фильтруйте данные по выбранной дате и отобразите их
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            string dates = "25/05/2023";
            
            GuestGrid.ItemsSource = AppData.db.tblReservations.Where(item => item.ReservationStartDate.Equals(dates)).ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            GuestGrid.ItemsSource = AppData.db.tblReservations.ToList();
        }
    }
}
