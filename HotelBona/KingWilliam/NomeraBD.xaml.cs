using KingWilliam.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Shapes;
using System.Diagnostics;

namespace KingWilliam
{
    /// <summary>
    /// Логика взаимодействия для NomeraBD.xaml
    /// </summary>
    public partial class NomeraBD : Window
    {
        public NomeraBD()
        {
            InitializeComponent();
        }
        string id = "";
        string type = "";
        string sql = "";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");

       
        public NomeraBD(string id, string type)
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
            RoomGrid.ItemsSource = AppData.db.tblRooms.ToList();

        }
        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                RoomGrid.ItemsSource = AppData.db.tblRooms.Where(item => item.RoomID.Contains(Poisk.Text)).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Nomera form = new Nomera();
            form.ShowDialog();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            RoomGrid.ItemsSource = AppData.db.tblRooms.Where(item => item.RoomTypeID.Contains("U")).ToList();
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            RoomGrid.ItemsSource = AppData.db.tblRooms.Where(item => item.RoomTypeID.Contains("S")).ToList();
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            RoomGrid.ItemsSource = AppData.db.tblRooms.Where(item => item.RoomTypeID.Contains("D")).ToList();
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RoomGrid.ItemsSource = AppData.db.tblRooms.ToList();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            RoomGrid.ItemsSource = AppData.db.tblRooms.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.ShowDialog();
            this.Close();
        }

        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            RoomGrid.ItemsSource = AppData.db.tblRooms.ToList();
        }

        private void CheckBox_Unchecked_2(object sender, RoutedEventArgs e)
        {
            RoomGrid.ItemsSource = AppData.db.tblRooms.ToList();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\Asus\Desktop\КоличествоБронирований.docx";

            // запускаем приложение Word и открываем файл
            Process.Start("WINWORD.EXE", filePath);
        }
    }
}
