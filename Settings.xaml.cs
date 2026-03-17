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
using System.Windows.Shapes;

namespace Project_Snake
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            slider.Value = Properties.Settings.Default.Slider;
            checkBox1.IsChecked = Properties.Settings.Default.Backup1;
            checkBox2.IsChecked = Properties.Settings.Default.Backup2;
        }

        private void Save_Settings(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Slider = (int)slider.Value;
            Properties.Settings.Default.Backup1 = checkBox1.IsChecked ?? false;
            Properties.Settings.Default.Backup2 = checkBox2.IsChecked ?? false;
            Properties.Settings.Default.Save();
            WindowSizeManager.SaveSize(this);
            var mainWindow = new MainWindow();
            WindowSizeManager.ApplySize(mainWindow);
            mainWindow.Show();
            this.Close();
        }
        private void Cancel_Settings(object sender, RoutedEventArgs e)
        {
            WindowSizeManager.SaveSize(this);
            var mainWindow = new MainWindow();
            WindowSizeManager.ApplySize(mainWindow);
            mainWindow.Show();
            this.Close();
        }
    }
}