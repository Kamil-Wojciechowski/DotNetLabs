namespace Zadanie02
{
    public partial class Form1 : Form
    {

        private Bitmap bitmap;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DrawAnalog(now);
            digitalText.Text = now.ToString("HH:mm:ss");
        }

        private void DrawAnalog(DateTime now)
        {
            double hourAngle = (now.Hour % 12 + now.Minute / 60.0) * 30;
            double minuteAngle = now.Minute * 6;
            double secondAngle = now.Second * 6;

            bitmap = new Bitmap(AnalogPanel.Width, AnalogPanel.Height);
            g = Graphics.FromImage(bitmap);

            g.FillEllipse(Brushes.White, 0, 0, AnalogPanel.Width, AnalogPanel.Height);
            g.DrawEllipse(Pens.Black, 0, 0, AnalogPanel.Width - 1, AnalogPanel.Height - 1);

            // Rysowanie wskazówek
            g.TranslateTransform(AnalogPanel.Width / 2, AnalogPanel.Height / 2);
            g.RotateTransform((float)hourAngle);
            g.DrawLine(Pens.Black, 0, 0, 0, -(AnalogPanel.Height / 4));
            g.RotateTransform((float)-hourAngle);
            g.RotateTransform((float)minuteAngle);
            g.DrawLine(Pens.Black, 0, 0, 0, -(AnalogPanel.Height / 3));
            g.RotateTransform((float)-minuteAngle);
            g.RotateTransform((float)secondAngle);
            g.DrawLine(Pens.Red, 0, 0, 0, -(AnalogPanel.Height / 3));
            g.ResetTransform();

            AnalogPanel.BackgroundImage = bitmap;
        }
    }
}