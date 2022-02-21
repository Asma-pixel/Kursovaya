using Microsoft.Win32;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;


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
            byte[] arr = Encoding.Unicode.GetBytes(encryptString.Text);
            int key = Convert.ToInt32(encryptKey.Text);
            encryptedTextValue.Text = Cezar.Encrypt(arr, key);
            encryptedTextValue.Visibility = Visibility.Visible;   
            encryptedTextBoxDescription.Visibility = Visibility.Visible;  


        }

        private void BtnClickInputStringFromFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }
    }
}
