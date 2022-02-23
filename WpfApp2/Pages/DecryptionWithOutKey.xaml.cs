using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для DecryptionWithOutSave.xaml
    /// </summary>
    public partial class DecryptionWithOutSave : Page
    {
        private static string lang;
        public DecryptionWithOutSave()
        {
            InitializeComponent();
            lang = "RU";
        }

        private void BtnClickDectyptSave(object sender, RoutedEventArgs e)
        {

            try
            {
         
                if (decryptString.Text == "" || decryptString.Text.Trim() == "")
                    throw new Exception("Введите строку для дешифрования");

                Regex rgx;
                if (lang == "EN")
                    rgx = new Regex(@"[а-яА-Я]");
                else
                    rgx = new Regex(@"[a-zA-Z]");
                if (rgx.IsMatch(decryptString.Text))
                    throw new Exception("Введите строку на нужном языке");

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
                MessageBox.Show(exc.Message.ToString(), "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnClickDecryptWithOutSave(object sender, RoutedEventArgs e)
        {
            try
            {
               
                if (decryptString.Text == "" || decryptString.Text.Trim() == "")
                    throw new Exception("Введите строку для дешифрования");
              

                Regex rgx;
                if (lang == "EN")
                    rgx = new Regex(@"[а-яА-Я]");
                else
                    rgx = new Regex(@"[a-zA-Z]");
                if (rgx.IsMatch(decryptString.Text))
                    throw new Exception("Введите строку на нужном языке");

              
                decryptedTextValue.Visibility = Visibility.Visible;
                decryptedTextBoxDescription.Visibility = Visibility.Visible;
                GridRowWithSttring.Height = new GridLength(5, GridUnitType.Star);
            }
            catch (Exception exc)
            {
                if (exc.Message.ToString().Contains("стр"))
                    decryptString.Text = "";

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
