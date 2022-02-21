using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

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

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void BtnClickDecryptWithOutSave(object sender, RoutedEventArgs e)
        {
            byte[] arr = Encoding.Unicode.GetBytes(decryptString.Text);
            int key = Convert.ToInt32(decryptKey.Text);
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
