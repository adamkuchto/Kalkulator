using System;
using System.Windows;

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

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
        }
        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
        }
        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
        }
        private void razyButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
        }
        private void dzielButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
        }
        private void powButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
        }
        private void moduloButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            equationLabel.Content = "";
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
            return Pow(n1,n2);
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
        Division
        // Dodaj więcej operatorów tutaj
    }
}

