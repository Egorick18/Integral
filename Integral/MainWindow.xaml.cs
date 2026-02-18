using System;
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

namespace Integr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var a = double.Parse(A.Text);
            }
            catch
            {
                MessageBox.Show(
                    "Введено некоректное числи a",
                    "Ошибка записи",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
                return;
            }
            try
            {
                var b = double.Parse(B.Text);
            }
            catch
            {
                MessageBox.Show(
                    "Введено некоректное числи b",
                    "Ошибка записи",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
                return;
            }
            try
            {
                var n = double.Parse(N.Text);
            }
            catch
            {
                MessageBox.Show(
                    "Введено некоректное числи n",
                    "Ошибка записи",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
                return;
            }
            try
            {
                var a = double.Parse(A.Text);
                var b = double.Parse(B.Text);
                var n = int.Parse(N.Text);

                Integrator i = new Integrator(a, b, n);
                var res = i.IntegrateByMidpointRule();
                Result.Text = res.ToString();
            }
            catch
            {
                MessageBox.Show(
                    "Ошибка вычисления",
                    "Внимание!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error
                );
            }
        }
    }
}