namespace Zadanie01
{
    public partial class Form1 : Form
    {

        private Boolean inGreen = false;
        public Form1()
        {
            InitializeComponent();
            redPanel.Visible = true;  
            yellowPanel.Visible = false;
            greenPanel.Visible = false;
            timer1.Interval = 3000;
            timer1.Start();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (inGreen)
            {
                greenPanel.Visible = false;
                yellowPanel.Visible = true;
                Thread.Sleep(2000);
                yellowPanel.Visible = false;
                redPanel.Visible = true;
            }
            else
            {
                redPanel.Visible = true;
                yellowPanel.Visible = true;
                Thread.Sleep(3000);
                redPanel.Visible = false;
                yellowPanel.Visible = false;
                greenPanel.Visible = true;
            }

            timer1.Start();
            inGreen = !inGreen;
        }
    }
}