using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project_Snake
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Start_Menu(object sender, RoutedEventArgs e)
        {
            WindowSizeManager.SaveSize(this);
            var modeSelection = new ModeSelection();
            WindowSizeManager.ApplySize(modeSelection);
            modeSelection.Show();
            this.Close();
        }
        private void Exit_Menu(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Settings_Menu(object sender, RoutedEventArgs e)
        {
            WindowSizeManager.SaveSize(this);
            var settings = new Settings();
            WindowSizeManager.ApplySize(settings);
            settings.Show();
            this.Close();
        }
    }
    public static class WindowSizeManager
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Top { get; set; }
        public static double Left { get; set; }
        public static WindowState State { get; set; } = WindowState.Normal;
        public static void SaveSize(Window window)
        {
            State = window.WindowState;

            if (State != WindowState.Maximized)
            {
                Width = window.Width;
                Height = window.Height;
                Top = window.Top;
                Left = window.Left;
            }
        }
        public static void ApplySize(Window window)
        {
            window.WindowState = State;

            if (State == WindowState.Normal)
            {
                window.Width = Width;
                window.Height = Height;
                window.Top = Top;
                window.Left = Left;
            }
        }
    }
}