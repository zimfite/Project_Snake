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
    /// Логика взаимодействия для ModeSelection.xaml
    /// </summary>
    public partial class ModeSelection : Window
    {
        public ModeSelection()
        {
            InitializeComponent();
        }

        private void OnTheField(object sender, RoutedEventArgs e)
        {
            WindowSizeManager.SaveSize(this);
            var field = new Field();
            WindowSizeManager.ApplySize(field);
            field.Show();
            this.Close();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            WindowSizeManager.SaveSize(this);
            var mainWindow = new MainWindow();
            WindowSizeManager.ApplySize(mainWindow);
            mainWindow.Show();
            this.Close();
        }
    }
}