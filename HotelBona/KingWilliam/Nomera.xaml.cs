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
using System.Windows.Shapes;

namespace KingWilliam
{
    /// <summary>
    /// Логика взаимодействия для Nomera.xaml
    /// </summary>
    public partial class Nomera : Window
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");


        public Nomera()
        {
            InitializeComponent();
            SqlDataReader reader = null;
            dpiStartDate.DisplayDateStart = DateTime.Now;
            dpiEndDate.DisplayDateStart = DateTime.Now;
            try
            {

                conn.Open();

                SqlCommand cmdType = new SqlCommand("select * from tblRoomType", conn);

                reader = cmdType.ExecuteReader();

                while (reader.Read())
                {
                    cmbRoomType.Items.Add(reader["TypeDescription"].ToString());
                }



            }
            finally
            {

                if (reader != null)
                {
                    reader.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }



        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Close();
        }


        private void cmbRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbRoomNumber.Items.Clear();


            if (dpiStartDate.Text != "" && dpiEndDate.Text != "")
            {
                reloadRoom();
            }
            else
            {
                cmbRoomType.SelectedIndex = -1;
            }
        }


        
          

        private void txtGuestID_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void dpiStartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dpiEndDate.DisplayDateStart = dpiStartDate.SelectedDate;
            dpiEndDate.Text = "";

        }

        private void dpiEndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cmbRoomType.SelectedIndex != -1)
            {
                reloadRoom();
            }
            //
        }

        private void reloadRoom()
        {
            cmbRoomNumber.Items.Clear();
            conn.Open();
            string type = "";
            SqlDataReader reader = null;
            try
            {

                SqlCommand cmdGetRoomTypeID = new SqlCommand("select RoomTypeID from tblRoomType where TypeDescription = '" + cmbRoomType.SelectedValue.ToString() + "'", conn);
                reader = cmdGetRoomTypeID.ExecuteReader();

                while (reader.Read())
                {
                    type = reader["RoomTypeID"].ToString();
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            SqlDataReader reader2 = null;
            try
            {
                //and StatusID = 1
                SqlCommand cmdRoomNumber = new SqlCommand("select RoomID from tblRooms inner join tblRoomType on tblRooms.RoomTypeID = tblRoomType.RoomTypeID where tblRooms.RoomTypeID = '" + type + "'  and (tblRooms.RoomID not in (select RoomID from tblReservations where ReservationEndDate >= '" + dpiStartDate.Text + "') or tblRooms.RoomID not in (select RoomID from tblReservations where ReservationStartDate <= '" + dpiEndDate.Text + "'))", conn);
                reader2 = cmdRoomNumber.ExecuteReader();
                while (reader2.Read())
                {
                    cmbRoomNumber.Items.Add(reader2["RoomID"].ToString());
                }
            }
            finally
            {
                if (reader2 != null)
                {
                    reader2.Close();
                }
            }
            if (conn != null)
            {
                conn.Close();
            }
        }



        protected int checkRoomStatus(string roomID)
        {
            int output = 0;
            try
            {
                conn.Open();
                SqlCommand check = new SqlCommand("select statusid from tblRooms where roomID = '" + roomID + "'", conn);
                var status = check.ExecuteScalar();
                output = int.Parse(status.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }


            return output;
        }

        private void cmbRoomNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int status = checkRoomStatus(cmbRoomNumber.SelectedValue.ToString());
            if (status == 2)
            {
               
            }
            else if (status == 3)
            {
            }
            else
            {
            }
        }

        private void btnGuest_Click(object sender, RoutedEventArgs e)
        {
            Guestt form = new Guestt();
            form.ShowDialog();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
