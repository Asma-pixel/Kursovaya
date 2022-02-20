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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2.Pages
{
    /// <summary>
    /// Логика взаимодействия для DecroptionWithKeyPage.xaml
    /// </summary>
    public partial class DecroptionWithKeyPage : Page
    {
        public DecroptionWithKeyPage()
        {
            InitializeComponent();
        }

        private void BtnClickDectyptSave(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClickDecryptWithOutSave(object sender, RoutedEventArgs e)
        {
            byte[] arr = Encoding.UTF8.GetBytes(decryptString.Text);
            int key = Convert.ToInt32(decryptKey.Text);
            encryptedTextValue.Text = Cezar.Encrypt(arr, key);
            encryptedTextValue.Visibility = Visibility.Visible;
            encryptedTextBoxDescription.Visibility = Visibility.Visible;
        }
    }
}
