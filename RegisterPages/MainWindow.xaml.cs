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
using RegisterPages.Controller;
using RegisterPages.Model;

namespace RegisterPages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Respon
    {
        MainWindowController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new MainWindowController();
            controller.SubcribeVerificationResult(this);
            
        }

        private void OnCheckboxEmailChecked(object sender, RoutedEventArgs e)
        {
            controller.SubscribeEmailVerification();
        }
        private void OnCheckboxEmailUnchecked(object sender, RoutedEventArgs e)
        {
            controller.UnsubscribeEmailVerification();
        }
        private void OnCheckboxWhatsappChecked(object sender, RoutedEventArgs e)
        {
            controller.SubscribeWAVerification();
        }
        private void OnCheckboxWhatsappUnhecked(object sender, RoutedEventArgs e)
        {
            controller.UnsubscribeWAVerification();
        }

        private void OnButtonDaftarClicked(object sender, RoutedEventArgs e)
        {
            controller.registeringUser(textBoxName.Text,textBoxEmail.Text,textBoxPhoneNumber.Text);
        }

        public void Jikaverifwasukses(object source, EventArgs e)
        {
            MessageBox.Show("Whatsaap Berhasil Dikirim ke " + textBoxPhoneNumber.Text, "Hello From Eventhandler #2816");
        }

        public void Jikaverifemailsukses(object source, EventArgs e)
        {
            MessageBox.Show("Email Berhasil Dikirim ke " + textBoxEmail.Text, "Hello From Eventhandler #2816");
        }

    }
}
