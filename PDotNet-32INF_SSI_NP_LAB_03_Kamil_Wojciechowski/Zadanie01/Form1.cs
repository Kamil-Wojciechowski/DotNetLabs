namespace Zadanie01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            secondDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void labelChange()
        {
            TimeSpan ts = firstDate.Value - secondDate.Value;
            result.Text = "D: " + ts.Days + " H: " + ts.Hours + " M: " + ts.Minutes + " S: " + ts.Seconds;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            labelChange();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            labelChange();
        }
    }
}