using System;
using System.Windows;
using WpfApp2.Pages;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            Manager.MainFrame.Navigate(new SelectionPage());
            Cezar.DecryptWithoutKey("привет мир", "RU");
            MessageBox.Show(Cezar.DecryptWithoutKey("Идейные соображения высшего порядка, нашей деятельности влечет за собой процесс внедрения и модернизации системы обучения кадров,соответствуетнасущнымотребностям.Разнообразныйибогатыйопытпостоянное", "RU"));
        }

        private void BtnClickBack(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
          
        }

        private void MainFrameRendered(object sender, EventArgs e)
        {
            if (Manager.MainFrame.CanGoBack)
                btnBack.Visibility = Visibility.Visible;
            else
                btnBack.Visibility = Visibility.Hidden;
        }
    }
}
