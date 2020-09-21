using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number1 = 0;
        int number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                        text.Text = (number1 + number2).ToString();
                    break;

                case "-":
                    text.Text = (number1 - number2).ToString();
                    break;

                case "*":
                    text.Text = (number1 * number2).ToString();
                    break;

                case "/":
                    text.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                text.Text = number2.ToString();
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                text.Text = number1.ToString();
            }
            else
            { 
                number2 = (number2 * 10) + 2;
                text.Text = number2.ToString();
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                text.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                text.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                text.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                text.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                text.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                text.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                text.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                text.Text = number2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            text.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            text.Text = "0";
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            text.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            text.Text = "0";
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 = 0;
                
            } else
            {
                number2 = 0;
                
            }

            text.Text = "0";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = ""; 
            text.Text = "0";
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                text.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                text.Text = number2.ToString();
            }
        }

        private void btnPositiveOrNegative_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = number1 * -1;
                text.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * -1;
                text.Text = number2.ToString();
            }
        }

        private void btnComma_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
