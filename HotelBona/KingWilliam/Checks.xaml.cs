using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
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
using System.Drawing.Printing;
using System.Drawing;

namespace KingWilliam
{
    /// <summary>
    /// Логика взаимодействия для Checks.xaml
    /// </summary>
    public partial class Checks : Window
    {
        public Checks()
        {
            InitializeComponent();
        }

        private string result = "";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewReservation form = new NewReservation();
            this.Close();
            form.ShowDialog();
        }
        
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(result, new Font("Arial", 14), System.Drawing.Brushes.Black, 0, 0);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conn.Open();
            SqlCommand id = new SqlCommand("SELECT ReservationID FROM tblReservations ORDER BY ReservationID DESC", conn);
            var result = id.ExecuteScalar();
            string price = "0";
            if (result != null)
            {
                price = result.ToString();
            }
            vivods.Content = price.ToString();

            conn.Close();

            conn.Open();
            SqlCommand room = new SqlCommand("SELECT RoomID FROM tblReservations ORDER BY ReservationID DESC", conn);
            var results = room.ExecuteScalar();
            string roomid = "0";
            if (result != null)
            {
                roomid = results.ToString();
            }
            nomer.Content = roomid.ToString();

            conn.Close();

            conn.Open();
            SqlCommand datef = new SqlCommand("SELECT ReservationStartDate FROM tblReservations ORDER BY ReservationID DESC", conn);
            var rdate = datef.ExecuteScalar();
            string datefs = "0";
            if (rdate != null)
            {
                datefs = rdate.ToString();
            }
            first.Content = datefs.ToString();

            conn.Close();

            conn.Open();
            SqlCommand dates = new SqlCommand("SELECT ReservationEndDate FROM tblReservations ORDER BY ReservationID DESC", conn);
            var sdate = dates.ExecuteScalar();
            string datese = "0";
            if (sdate != null)
            {
                datese = sdate.ToString();
            }
            second.Content = datese.ToString();

            conn.Close();

            conn.Open();
            SqlCommand priceday = new SqlCommand("SELECT DATEDIFF(day, ReservationStartDate, ReservationEndDate) AS days_diff FROM tblReservations ORDER BY ReservationID DESC", conn);
            var daypri = priceday.ExecuteScalar();
            int dayric = 0;
            if (daypri != null)
            {
                dayric = int.Parse(daypri.ToString());
            }
            third.Content = (dayric * 150 + " " + "руб. " + " " + "за" + " " + dayric + " " + "дней");

            conn.Close();


            thirds.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            nazad.Visibility = Visibility.Hidden;
            ce.Visibility = Visibility.Hidden;
            PrintDialog p = new PrintDialog();
            if(p.ShowDialog() == true)
            {
                p.PrintVisual(checkgrid, "Печать");
            }
        }


    }
}
