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

                if (n <= 0)
                {
                    MessageBox.Show(
                        "Число разбиений должно быть натуральным",
                        "Ошибка записи",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error
                    );
                };

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
                
                if (a > b)
                {
                    var result = MessageBox.Show(
                        "Нижняя граница ({a}) больше верхней ({b}). Поменять их местами?",
                        "Некорректный интервал",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question
                    );

                    if (result == MessageBoxResult.Yes)
                    {
                        (a, b) = (b, a);

                        A.Text = a.ToString();
                        B.Text = b.ToString();

                        MessageBox.Show(
                            "Границы успешно изменены: a = {a}, b = {b}",
                            "Информация",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information
                        );
                    }
                }

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