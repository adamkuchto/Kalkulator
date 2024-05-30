using System;
using System.Windows;
using System.Windows.Controls;

namespace Kalkulator
{
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        SelectedOperator selectedOperator;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string content = button.Content.ToString();
                inputField.Text += content;
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
            inputField.Text = "";
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            string[] numbers = inputField.Text.Split(',');
            if (numbers.Length == 2)
            {
                double a = Convert.ToDouble(numbers[0]);
                double b = Convert.ToDouble(numbers[1]);

                double result = a + b;

                resultLabel.Content = result.ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            inputField.Text = "";
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            string[] numbers = inputField.Text.Split(',');
            if (numbers.Length == 2)
            {
                double a = Convert.ToDouble(numbers[0]);
                double b = Convert.ToDouble(numbers[1]);

                double result = a - b;

                resultLabel.Content = result.ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            inputField.Text = "";
        }

        private void RazyButton_Click(object sender, RoutedEventArgs e)
        {
            string[] numbers = inputField.Text.Split(',');
            if (numbers.Length == 2)
            {
                double a = Convert.ToDouble(numbers[0]);
                double b = Convert.ToDouble(numbers[1]);

                double result = a * b;

                resultLabel.Content = result.ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            inputField.Text = "";
        }
        private void DzielButton_Click(object sender, RoutedEventArgs e)
        {
            string[] numbers = inputField.Text.Split(',');
            if (numbers.Length == 2)
            {
                double a = Convert.ToDouble(numbers[0]);
                double b = Convert.ToDouble(numbers[1]);
                if (b == 0)
                {
                    MessageBox.Show("Nie dzielimy przez zero");
                    return;
                }

                double result = a / b;

                resultLabel.Content = result.ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            inputField.Text = "";
        }

        private void PowButton_Click(object sender, RoutedEventArgs e)
        {
            string[] numbers = inputField.Text.Split(',');
            if (numbers.Length == 2)
            {
                double baseNumber = Convert.ToDouble(numbers[0]);
                double exponent = Convert.ToDouble(numbers[1]);

                double result = SimpleMath.Pow(baseNumber, exponent);

                resultLabel.Content = result.ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            inputField.Text = "";
        }

        private void ModuloButton_Click(object sender, RoutedEventArgs e)
        {
            string[] numbers = inputField.Text.Split(',');
            if (numbers.Length == 2)
            {
                double a = Convert.ToDouble(numbers[0]);
                double b = Convert.ToDouble(numbers[1]);

                double result = a % b;

                resultLabel.Content = result.ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem", "Invalid input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            inputField.Text = "";
        }
    }

    public static class SimpleMath
    {
        public static double Pow(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
    }
    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Power,
        Modulo
    }
}
