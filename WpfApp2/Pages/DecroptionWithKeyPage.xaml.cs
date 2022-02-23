using Microsoft.Win32;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2.Pages
{
    /// <summary>
    /// Логика взаимодействия для DecroptionWithKeyPage.xaml
    /// </summary>
    /// 
    public partial class DecroptionWithKeyPage : Page
    {
        private string lang;
        public DecroptionWithKeyPage()
        {
            InitializeComponent();
            lang = "RU";
        }

        private void BtnClickDectyptSave(object sender, RoutedEventArgs e)
        {

            try
            {
                if ((decryptString.Text == "" || decryptString.Text.Trim() == "") && decryptKey.Text == "")
                    throw new Exception("Введите строку и ключ для дешифрования");
                if (decryptString.Text == "" || decryptString.Text.Trim() == "")
                    throw new Exception("Введите строку для дешифрования");
                if (decryptKey.Text == "")
                    throw new Exception("Введите ключ");

                decryptedTextValue.Text = Cezar.DecryptWithKey(decryptString.Text, Convert.ToInt32(decryptKey.Text), lang);
                decryptedTextValue.Visibility = Visibility.Visible;
                decryptedTextBoxDescription.Visibility = Visibility.Visible;
                
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text files(*.txt)|*.txt";
                save.CreatePrompt = true;
                save.Title = "Сохранение дешифрованной строки";
                save.OverwritePrompt = true;

                if (save.ShowDialog() == false)
                    return;

                string filename = save.FileName;
           
                System.IO.File.WriteAllText(filename, decryptedTextValue.Text);
                GridRowWithSttring.Height = new GridLength(5, GridUnitType.Star);
            }
            catch (Exception exc)
            {
                if (exc.Message.ToString().Contains("стр"))
                    decryptString.Text = "";
                if (exc.Message.ToString().Contains("Значение"))
                    decryptKey.Text = "";
                MessageBox.Show(exc.Message.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnClickDecryptWithOutSave(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((decryptString.Text == "" || decryptString.Text.Trim() == "") && decryptKey.Text == "")
                    throw new Exception("Введите строку и ключ для дешифрования");
                if (decryptString.Text == "" || decryptString.Text.Trim() == "")
                    throw new Exception("Введите строку для дешифрования");
                if (decryptKey.Text == "")
                    throw new Exception("Введите ключ");

                decryptedTextValue.Text = Cezar.DecryptWithKey(decryptString.Text, Convert.ToInt32(decryptKey.Text), lang);
                decryptedTextValue.Visibility = Visibility.Visible;
                decryptedTextBoxDescription.Visibility = Visibility.Visible;
                GridRowWithSttring.Height = new GridLength(5, GridUnitType.Star);
            }
            catch (Exception exc)
            {
                if (exc.Message.ToString().Contains("стр"))
                    decryptString.Text = "";
                if (exc.Message.ToString().Contains("Значение"))
                    decryptKey.Text = "";
                
                MessageBox.Show(exc.Message.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
          
        }

        private void BtnClickInputStringFromFile(object sender, RoutedEventArgs e)
        {
            try
            {
                string checkLang = "";
                Regex rgx;
                if (lang == "EN")
                {
                    rgx = new Regex(@"[а-яА-Я]");
                    checkLang = "русского";
                }

                else
                {
                    rgx = new Regex(@"[a-zA-Z]");
                    checkLang = "английского";
                }

                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == false)
                    return;
                string filename = openFileDialog.FileName;
                string fileText = System.IO.File.ReadAllText(filename);

                if (rgx.IsMatch(fileText))
                    throw new Exception($"В файле встречаются символы {checkLang} языка");
               
                decryptString.Text = fileText;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
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
            if (decryptString != null)
                decryptString.Text = null;

            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;
            if (selectedItem.Content != null)
                lang = selectedItem.Content.ToString();

        }

        private void TextInputKey(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex rgx = new Regex(@"\d");
            if (!rgx.IsMatch(e.Text))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void KeyDownBlockSpace(object sender, System.Windows.Input.KeyEventArgs e)
        {
            e.Handled = e.KeyboardDevice.IsKeyDown(System.Windows.Input.Key.Space);
        }

    }
}
