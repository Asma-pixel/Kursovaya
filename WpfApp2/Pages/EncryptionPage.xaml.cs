using Microsoft.Win32;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp2.Pages
{
    /// <summary>
    /// Логика взаимодействия для EncryptionPage.xaml
    /// </summary>
    public partial class EncryptionPage : Page
    {
        private string lang;
        public EncryptionPage()
        {
            InitializeComponent();
            lang = "RU";
            
        }

        private void BtnClickEncryptSave(object sender, RoutedEventArgs e)
        {
            try
            {
                if (encryptString.Text == "")
                    throw new Exception("Введите строку для шифрования");
                if (encryptKey.Text == "")
                    throw new Exception("Введите ключ");

                encryptedTextValue.Text = Cezar.Encrypt(encryptString.Text, Convert.ToInt32(encryptKey.Text), "RU");
                encryptedTextValue.Visibility = Visibility.Visible;
                encryptedTextBoxDescription.Visibility = Visibility.Visible;
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files(*.txt)|*.txt";
                save.CreatePrompt = true;
                save.Title = "Сохранение зашифрованной строки";
                save.OverwritePrompt = true;
                if (save.ShowDialog() == false)
                    return;
                // получаем выбранный файл
                string filename = save.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, encryptedTextValue.Text);
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        private void BtnClickEncryptWithOutSave(object sender, RoutedEventArgs e)
        {
            encryptedTextValue.Text = Cezar.Encrypt(encryptString.Text, Convert.ToInt32(encryptKey.Text), "RU");
            encryptedTextValue.Visibility = Visibility.Visible;   
            encryptedTextBoxDescription.Visibility = Visibility.Visible;  
        }

        private void BtnClickInputStringFromFile(object sender, RoutedEventArgs e)
        {
            encryptedTextValue.Text = Cezar.Encrypt(encryptString.Text, Convert.ToInt32(encryptKey.Text), "RU");
            encryptedTextValue.Visibility = Visibility.Visible;   
            encryptedTextBoxDescription.Visibility = Visibility.Visible;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text files(*.txt)|*.txt|";
            save.CreatePrompt = true;
            save.Title = "asdfa";
            save.OverwritePrompt = true;
            save.ShowDialog();
            // получаем выбранный файл
            string filename = save.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, encryptedTextValue.Text);
        }

        private void TextInputString(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex rgx;
            if (lang == "EN")
                rgx = new Regex(@"[а-яА-Я]");
            else
                rgx = new Regex(@"[a-zA-Z]");

            if (rgx.IsMatch(e.Text))
                e.Handled = true;
            else
               e.Handled = false;
        }


        private void SelectLang(object sender, SelectionChangedEventArgs e)
        {
            if (encryptString != null)
                encryptString.Text = null;

            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            if (selectedItem.Content != null)
                lang  = selectedItem.Content.ToString();
                
        }

        private void TextInputKey(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex rgx = new Regex(@"\d");
            if (!rgx.IsMatch(e.Text))
                e.Handled = true;
            else
                e.Handled = false;
        }

    }
}
