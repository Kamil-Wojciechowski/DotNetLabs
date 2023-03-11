namespace Zadanie02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Double numOne;
        private Double numTwo;

        private void numberOne_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numOne = Convert.ToDouble(numberOne.Text);
            }
            catch
            {
                numOne = 0;
                numberOne.Text = "0";
            }

        }

        private void numberTwo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numTwo = Convert.ToDouble(numberTwo.Text);
            }
            catch
            {
                numTwo = 0;
                numberTwo.Text = "0";
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            result.Text = (numOne + numTwo).ToString();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            result.Text = (numOne - numTwo).ToString();
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            result.Text = (numOne * numTwo).ToString();
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (numTwo == 0)
            {
                result.Text = "Nie dziel przez 0";
            }
            else
            {
                result.Text = (numOne / numTwo).ToString();
            }
        }
    }
}