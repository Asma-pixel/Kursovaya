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
    /// Логика взаимодействия для SelectionPage.xaml
    /// </summary>
    public partial class SelectionPage : Page
    {
        public SelectionPage()
        {
            InitializeComponent();
            
        }

        private void BtnClickOpenPage(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            switch(btn.Name)
            {
                case "btnEncrypt": Manager.MainFrame.Navigate(new EncryptionPage());  break;
                case "btnDecryptKey": Manager.MainFrame.Navigate(new DecroptionWithKeyPage()); break;   
            }
           
        }
    }
}
