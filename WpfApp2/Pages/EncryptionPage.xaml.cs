using Microsoft.Win32;
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
    /// Логика взаимодействия для EncryptionPage.xaml
    /// </summary>
    public partial class EncryptionPage : Page
    {
        public EncryptionPage()
        {
            InitializeComponent();
            
        }

        private void BtnClickEncryptSave(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void BtnClickEncryptWithOutSave(object sender, RoutedEventArgs e)
        {
            byte[] arr = Encoding.UTF8.GetBytes(encryptString.Text);
            int key = Convert.ToInt32(encryptKey.Text);
            encryptedTextValue.Text = Cezar.Encrypt(arr, key);
            encryptedTextValue.Visibility = Visibility.Visible;   
            encryptedTextBoxDescription.Visibility = Visibility.Visible;  


        }
    }
}
