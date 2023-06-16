using System;
using System.Collections.Generic;
using System.Diagnostics;
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


namespace KingWilliam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           
           NewReservation newReservationForm = new NewReservation();
           newReservationForm.Show();
            this.Close();
        }
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

            EditTransaction Form = new EditTransaction();
            Form.Show();
            this.Close();
        }


        private void btnPricing_Click(object sender, RoutedEventArgs e)
        {
            RoomPricing form = new RoomPricing();
            form.Show();
            this.Close();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            RoomServices form = new RoomServices();
            form.Show();
            this.Close();
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Reserv form = new Reserv();
            form.Show();
            this.Close();
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            
            Guestt form = new Guestt();
            this.Close();
            form.ShowDialog();
            
        }

        /*private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            ReportsMenu form = new ReportsMenu();
            form.ShowDialog();
            
        }*/

        private void btnExistingTransaction_Click(object sender, RoutedEventArgs e)
        {
            ExistingReservation form = new ExistingReservation();
            form.ShowDialog();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Guestt form = new Guestt();
            form.ShowDialog();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Reserv form = new Reserv();
            this.Close();
            form.ShowDialog();

        }

        private void btnPricing_Copy_Click(object sender, RoutedEventArgs e)
        {
            NomeraBD form = new NomeraBD();
            this.Close();
            form.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void btnPricing_Copy1_Click(object sender, RoutedEventArgs e)
        {
            NomeraBD form = new NomeraBD();
            this.Close();
            form.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string filePath = @"C:\Users\Asus\Desktop\ПоНомерам.docx";

            // запускаем приложение Word и открываем файл
            Process.Start("WINWORD.EXE", filePath);
        }

    }
}
