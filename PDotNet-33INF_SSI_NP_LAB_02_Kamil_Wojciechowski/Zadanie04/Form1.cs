namespace Zadanie04
{
    public partial class Form1 : Form
    {
        private String firstNumber = "";
        private String secondNumber = "";
        private String toView;
        private Int16 size = 15;

        private String operation = "";

        private Boolean dot = false;
        private Boolean firstItem = true;



        public Form1()
        {
            InitializeComponent();
        }

        private void zeroBt_Click(object sender, EventArgs e)
        {
            if (firstNumber == "" || Convert.ToDouble(firstNumber) != 0)
            {
                AppendItem("0");
            }

        }

        private void oneBt_Click(object sender, EventArgs e)
        {
            AppendItem("1");
        }

        private void twoBt_Click(object sender, EventArgs e)
        {
            AppendItem("2");
        }

        private void threeBt_Click(object sender, EventArgs e)
        {
            AppendItem("3");
        }

        private void fourBt_Click(object sender, EventArgs e)
        {
            AppendItem("4");
        }

        private void fiveBt_Click(object sender, EventArgs e)
        {
            AppendItem("5");
        }

        private void sixBt_Click(object sender, EventArgs e)
        {
            AppendItem("6");
        }

        private void sevenBt_Click(object sender, EventArgs e)
        {
            AppendItem("7");
        }

        private void eightBt_Click(object sender, EventArgs e)
        {
            AppendItem("8");
        }

        private void nineBt_Click(object sender, EventArgs e)
        {
            AppendItem("9");
        }

        private void AppendItem(String item)
        {
            if (result.Text.Length <= size)
            {
                if (firstItem && firstNumber == "0")
                {
                    firstNumber = item;
                }
                else if (firstItem)
                {
                    firstNumber = String.Concat(firstNumber + item);
                }
                else if (!firstItem && secondNumber == "0")
                {
                    secondNumber = item;
                }
                else
                {
                    secondNumber = String.Concat(secondNumber + item);
                }

                if (firstItem)
                {
                    result.Text = firstNumber;
                }
                else
                {
                    result.Text = secondNumber;
                }
            }
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstItem)
                {
                    firstNumber = firstNumber.Substring(0, (firstNumber.Length - 1));
                    result.Text = firstNumber;
                }
                else
                {
                    secondNumber = secondNumber.Substring(0, (firstNumber.Length - 1));
                    result.Text = secondNumber;
                }
            }
            catch (Exception exception)
            {
                if (firstItem)
                {
                    firstNumber = "";
                }
            }

        }

        private void changeMinusBt_Click(object sender, EventArgs e)
        {
            if (firstItem && firstNumber != "")
            {
                Double current = Convert.ToDouble(firstNumber);

                if (current != 0)
                {
                    current *= -1;

                    firstNumber = current.ToString();
                    result.Text = firstNumber;
                }
            }
            else if (!firstItem && secondNumber != "")
            {
                Double current = Convert.ToDouble(secondNumber);

                if (current != 0)
                {
                    current *= -1;

                    secondNumber = current.ToString();
                    result.Text = secondNumber;
                }
            }
        }

        private void cBt_Click(object sender, EventArgs e)
        {
            firstItem = true;
            firstNumber = "";
            secondNumber = "";
            result.Text = "";
        }

        private void resultBt_Click(object sender, EventArgs e)
        {
            try
            {
                Double numberOne = Convert.ToDouble(firstNumber);
                Double numberTwo = Convert.ToDouble(secondNumber);

                String numResult = "";

                switch (operation)
                {
                    case "+":
                        numResult = (numberOne + numberTwo).ToString();
                        break;
                    case "-":
                        numResult = (numberOne - numberTwo).ToString();
                        break;
                    case "*":
                        numResult = (numberOne * numberTwo).ToString();
                        break;
                    case "/":
                        if (numberTwo == 0)
                        {
                            //TODO
                        }
                        else
                        {
                            numResult = (numberOne / numberTwo).ToString();
                        }

                        break;
                }

                firstNumber = numResult;
                secondNumber = "";
                result.Text = numResult;
                firstItem = false;
            }
            catch
            {

            }

        }
        private void plusBt_Click(object sender, EventArgs e)
        {
            if (firstItem)
            {
                firstItem = false;
                dot = false;
            }
            else
            {
                resultBt_Click(sender, e);
            }
            operation = "+";

        }

        private void minBt_Click(object sender, EventArgs e)
        {
            if (firstItem)
            {
                firstItem = false;
                dot = false;
            }
            else
            {
                resultBt_Click(sender, e);
            }
            operation = "-";

        }

        private void mulBt_Click(object sender, EventArgs e)
        {
            if (firstItem)
            {
                firstItem = false;
                dot = false;
            }
            else
            {
                resultBt_Click(sender, e);
            }
            operation = "*";
        }

        private void divBt_Click(object sender, EventArgs e)
        {
            if (firstItem)
            {
                firstItem = false;
                dot = false;
            }
            else
            {
                resultBt_Click(sender, e);
            }
            operation = "/";
        }

        private void ceBt_Click(object sender, EventArgs e)
        {
            if (firstItem)
            {
                operation = "";
                firstNumber = "";
                result.Text = firstNumber;
            }
            else
            {
                secondNumber = "";
                result.Text = secondNumber;
            }
        }

        private void dotBt_Click(object sender, EventArgs e)
        {
            if (!dot)
            {
                AppendItem("0,");
                dot = true;
            }
            else if (!dot)
            {
                AppendItem(",");
            }
        }

        private void divByXBt_Click(object sender, EventArgs e)
        {
            if (firstItem && firstNumber != "" && firstNumber != "0")
            {
                Double numberOne = Convert.ToDouble(firstNumber);
                String opeResult = (1 / numberOne).ToString();

                firstNumber = opeResult;
                result.Text = opeResult;
                firstItem = false;
            }
            else if (!firstItem && secondNumber != "" && secondNumber != "0")
            {
                Double numberTwo = Convert.ToDouble(secondNumber);
                String opeResult = (1 / numberTwo).ToString();

                secondNumber = "";
                firstNumber = opeResult;
                result.Text = opeResult;
                firstItem = false;
            }
            else if (!firstItem && (secondNumber == "" || secondNumber == "0" || secondNumber == "0,"))
            {
                Double numberOne = Convert.ToDouble(firstNumber);
                String opeResult = (1 / numberOne).ToString();

                firstNumber = opeResult;
                result.Text = opeResult;
                firstItem = false;
            }
        }

        private void xToSquareBt_Click(object sender, EventArgs e)
        {
            operation = "*";
            secondNumber = firstNumber;
            resultBt_Click(sender, e);
        }

        private void sqrtBt_Click(object sender, EventArgs e)
        {
            if (firstItem && firstNumber != "")
            {
                firstNumber = Math.Sqrt(Convert.ToDouble(firstNumber)).ToString();
                result.Text = firstNumber;
            }
            else if (secondNumber != "")
            {
                secondNumber = Math.Sqrt(Convert.ToDouble(secondNumber)).ToString();
                result.Text = secondNumber;
                
            }
        }
    }
}