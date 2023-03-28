using System.Drawing.Imaging;

namespace Zadanie07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            appendColums();
            appendData();
        }

        private void appendColums()
        {
            listView1.Columns.Add("Kodek");
            listView1.Columns.Add("Opis");
        }

        private void appendData()
        {
            ImageCodecInfo[] data = ImageCodecInfo.GetImageEncoders();
        }
    }
}