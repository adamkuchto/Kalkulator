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
            Button_Click(sender, e);
        }
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
            Button_Click(sender, e);
        }
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
            Button_Click(sender, e);
        }
        private void RazyButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
            Button_Click(sender, e);
        }
        private void DzielButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
            Button_Click(sender, e);
        }
        private void PowButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
            Button_Click(sender, e);
        }

        private void ModuloButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
            Button_Click(sender, e);
        }
    }

    public static class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Divide(double n1, double n2)
        {
            if (n2 == 0)
            {
                MessageBox.Show("Dzielenie przez 0 nie jest obsługiwane.", "Błędna operacja", MessageBoxButton.OK, MessageBoxImage.Error);
                return 0;
            }

            return n1 / n2;
        }
        public static double Pow(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
        public static double Modulo(double n1, double n2)
        {
            return n1 % n2;
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
