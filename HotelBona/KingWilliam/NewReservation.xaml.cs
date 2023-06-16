using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Data;
using System.Windows.Markup;
using System.Drawing;

namespace KingWilliam
{
    /// <summary>
    /// Interaction logic for NewReservation.xaml
    /// </summary>
    public partial class NewReservation : Window
    {
        //string hotelConnectionString = "Data Source=PARTH-LAPPY;Initial Catalog=KingWilliamHotelDB;Integrated Security=True";
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-078D6KH;Initial Catalog=KingWilliamHotelDB;Integrated Security=True");


        public NewReservation()
        {
            InitializeComponent();
            rdbExistingGuest.IsChecked = true;
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

        private void rdbNewGuest_Checked(object sender, RoutedEventArgs e)
        {
            cnvGuest.Visibility = Visibility.Visible;
            btnCheck.Visibility = Visibility.Hidden;
            btnGuest.Visibility = Visibility.Hidden;
            txtGuestID.Visibility = Visibility.Hidden;
            lblGuestID.Visibility = Visibility.Hidden;
            cnvReservation.Margin= new Thickness(366, 450, 432.2, 182.2);
            conn.Open();
            SqlDataReader rdr = null;
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 GuestID FROM tblGuests ORDER BY GuestID DESC", conn);
            rdr = cmd.ExecuteReader();
            string guestid = "";
            while (rdr.Read())
            {
                guestid = rdr["GuestID"].ToString();
            }

            int id = int.Parse(guestid.Substring(1)) + 1;
            guestid = "G" + id.ToString().PadLeft(5, '0'); ;
            txtGuestID.Text = guestid;
            if (rdr != null)
            {
                rdr.Close();
            }
            if (conn != null)
            {
                conn.Close();
            }
            txtGuestID.IsEnabled = false;
        }

        private void rdbExistingGuest_Checked(object sender, RoutedEventArgs e)
        {
            cnvGuest.Visibility = Visibility.Hidden;
            btnCheck.Visibility = Visibility.Visible;
            txtGuestID.Visibility = Visibility.Visible;
            lblGuestID.Visibility = Visibility.Visible;
            btnGuest.Visibility = Visibility.Visible;
            cnvReservation.Margin = new Thickness(366, 300, 432.2, 342.2);
            txtGuestID.Clear();
            txtGuestID.IsEnabled = true;

        }

        private void cmbRoomType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cmbRoomNumber.Items.Clear();

            lblMessage.Content = "";
            if(dpiStartDate.Text !="" && dpiEndDate.Text !="")
            {
                reloadRoom();
            }
            else
            {
                lblMessage.Content = "Дата отъезда и дата выезда должны быть выбраны";
                cmbRoomType.SelectedIndex=-1;
                double money = 0;
                SqlCommand type = new SqlCommand("SELECT TOP 1 Cost FROM tblRooms inner join tblRoomType on tblRooms.RoomTypeID = tblRoomType.RoomTypeID where TypeDescription ='" + cmbRoomType.SelectedValue.ToString() + "'", conn);
                var cost = type.ExecuteScalar();
                if (cost != null)
                {
                    money = double.Parse(cost.ToString());

                }
                txtPrice.Text = money.ToString("#.##" + " " + "руб. за ночь");
            }
        }


        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (rdbExistingGuest.IsChecked == true)
            {
                string error = "";
                conn.Open();
                if (txtGuestID.Text != "")
                {
                    if (isUserExist(txtGuestID.Text) > 0)
                    {
                        if (cmbRoomType.SelectedItem == null || cmbRoomNumber.SelectedItem == null)
                        {
                            error += "\n Нужно выбрать комнату!!";
                        }
                        if (dpiStartDate.Text == "" || dpiEndDate.Text == "")
                        {
                            error += "\n Нужно выбрать дату!!";
                        }

                        if (error == "")
                        {
                            SqlCommand insertReservation = new SqlCommand("INSERT INTO tblReservations (GuestID,RoomID,EmployeeID,DateMade, ReservationStartDate,ReservationEndDate) VALUES (@guest,@room,@emp,CONVERT (date, SYSDATETIME()),@start,@end)", conn);
                            insertReservation.Parameters.Add(new SqlParameter("guest", txtGuestID.Text));
                            insertReservation.Parameters.Add(new SqlParameter("room", cmbRoomNumber.Text));
                            insertReservation.Parameters.Add(new SqlParameter("emp", txtEmployeeID.Text));
                            insertReservation.Parameters.Add(new SqlParameter("start", dpiStartDate.Text));
                            insertReservation.Parameters.Add(new SqlParameter("end", dpiEndDate.Text));
                            int r = insertReservation.ExecuteNonQuery();
                            if (r == 0)
                            {
                                MessageBox.Show("Невозможно забронировать!");
                            }
                            else
                            {
                                MessageBox.Show("Генерация чека...");
                                Checks rs = new Checks();
                                rs.Show();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show(error);
                        }
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("\nГость с ID - " + txtGuestID.Text + " не найден\n");
                        txtGuestID.Focus();
                        txtGuestID.SelectAll();

                    }
                }
                else
                {
                    MessageBox.Show("Такого гостя не существует!");
                }



                conn.Close();

            }
            else if (rdbNewGuest.IsChecked == true)
            {
                string error = "";
                conn.Open();
                if (cmbRoomType.SelectedItem == null || cmbRoomNumber.SelectedItem == null)
                {
                    error += "\n Номер должен быть выбран!";
                }
                if (dpiStartDate.Text == "" || dpiEndDate.Text == "")
                {
                    error += "\n Дата должна быть выбрана!";
                }
                if (txtFirstName.Text == "" || txtLastName.Text == "")
                {
                    error += "\nИмя и Фамилия обязательны к заполнению!";
                }
                if (txtPhone.Text == "")
                {
                    error += "\nВведите номер телефона!";
                }
                if (txtPhone.Text.Length != 13)
                {
                    error += "\nТелефон номер должен состоять из 13 символов!";
                }
                if (txtAddress.Text == "")
                {
                    error += "\nУкажите номер паспорта.";
                }
                if (txtEmail.Text.Contains("@"))
                {

                }
                else
                {
                    error += "\nE-mail адрес введен неверно";
                }


                if (error == "")
                {
                    SqlCommand insertGuest = new SqlCommand("INSERT INTO tblGuests (GuestID,FirstName,LastName,GuestAddress, PostalCode,Phone,EmailAddress) VALUES (@guest,@first,@last,@address,@postal,@phone,@email)", conn);

                    insertGuest.Parameters.Add(new SqlParameter("guest", txtGuestID.Text));
                    insertGuest.Parameters.Add(new SqlParameter("first", txtFirstName.Text));
                    insertGuest.Parameters.Add(new SqlParameter("last", txtLastName.Text));
                    insertGuest.Parameters.Add(new SqlParameter("address", txtAddress.Text));
                    insertGuest.Parameters.Add(new SqlParameter("postal", (pol.Text).ToUpper()));
                    insertGuest.Parameters.Add(new SqlParameter("phone", txtPhone.Text));
                    insertGuest.Parameters.Add(new SqlParameter("email", txtEmail.Text));
                    int result = insertGuest.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Невозможно добавить гостя!");
                    }
                    else
                    {
                        SqlCommand insertReservation = new SqlCommand("INSERT INTO tblReservations (GuestID,RoomID,EmployeeID,DateMade, ReservationStartDate,ReservationEndDate) VALUES (@guest,@room,@emp,CONVERT (date, SYSDATETIME()),@start,@end)", conn);
                        insertReservation.Parameters.Add(new SqlParameter("guest", txtGuestID.Text));
                        insertReservation.Parameters.Add(new SqlParameter("room", cmbRoomNumber.Text));
                        insertReservation.Parameters.Add(new SqlParameter("emp", txtEmployeeID.Text));
                        insertReservation.Parameters.Add(new SqlParameter("start", dpiStartDate.Text));
                        insertReservation.Parameters.Add(new SqlParameter("end", dpiEndDate.Text));
                        int r = insertReservation.ExecuteNonQuery();
                        if (r == 0)
                        {
                            MessageBox.Show("Невозможно забронировать!");
                        }
                        else
                        {
                            Checks rs = new Checks();
                            rs.Show();
                            this.Close();
                            MessageBox.Show("Генерация чека...");
                            
                        }
                    }


                }
                else
                {
                    MessageBox.Show(error);
                }
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }
            private void txtGuestID_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }

        private void dpiStartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            lblMessage.Content = "";
            dpiEndDate.DisplayDateStart = dpiStartDate.SelectedDate;
            dpiEndDate.Text = "";
            
        }

        private void dpiEndDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            lblMessage.Content = "";
            if(cmbRoomType.SelectedIndex != -1)
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

        private int isUserExist(string id)
        {
            
            SqlCommand checkUser = new SqlCommand("select count(*) from tblGuests where GuestID = '" + id + "'", conn);
            int userExist = (int)checkUser.ExecuteScalar();
                      

            return userExist;
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            Window check = new CheckPreviousRoom(txtGuestID.Text);
            check.ShowDialog();
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
                if(conn != null)
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
                lblMessage.Content = "Комнате " + cmbRoomNumber.SelectedValue.ToString() + "необходима уборка!";
            }
            else if (status == 3)
            {
                lblMessage.Content = "Комнате " + cmbRoomNumber.SelectedValue.ToString() + "необходимо полное обслуживание!";
            }
            else
            {
                conn.Open();
                lblMessage.Content = "";
                double money = 0;
                SqlCommand type = new SqlCommand("SELECT TOP 1 Cost FROM tblRooms inner join tblRoomType on tblRooms.RoomTypeID = tblRoomType.RoomTypeID where TypeDescription ='" + cmbRoomType.SelectedValue.ToString() + "'", conn);
                var cost = type.ExecuteScalar();
                if (cost != null)
                {
                    money = double.Parse(cost.ToString());

                }
                txtPrice.Text = money.ToString("#.##" + " " + "руб. за ночь");
                conn.Close();
            } 
        }

        private void btnGuest_Click(object sender, RoutedEventArgs e)
        {
            Guestt form = new Guestt();
            form.ShowDialog();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double money = 0;
            SqlCommand type = new SqlCommand("SELECT TOP 1 Cost FROM tblRooms inner join tblRoomType on tblRooms.RoomTypeID = tblRoomType.RoomTypeID where TypeDescription ='" + cmbRoomType.SelectedValue.ToString() + "'", conn);
            var cost = type.ExecuteScalar();
            if (cost != null)
            {
                money = double.Parse(cost.ToString());

            }
            txtPrice.Text = money.ToString("#.##" + " " + "руб. за ночь");
        }

        private void txtPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            double money = 0;
            SqlCommand type = new SqlCommand("SELECT TOP 1 Cost FROM tblRooms inner join tblRoomType on tblRooms.RoomTypeID = tblRoomType.RoomTypeID where TypeDescription ='" + cmbRoomType.SelectedValue.ToString() + "'", conn);
            var cost = type.ExecuteScalar();
            if (cost != null)
            {
                money = double.Parse(cost.ToString());

            }
            txtPrice.Text = money.ToString("#.##" + " " + "руб. за ночь");
        }
    }
}
