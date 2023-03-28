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
            listView1.View = View.Details;
            listView1.Columns.Add("Kodek");
            listView1.Columns.Add("Rozszerzenie");
            listView1.Columns.Add("Opis");
        }

        private void appendData()
        {
            ImageCodecInfo[] data = ImageCodecInfo.GetImageEncoders();

            foreach(var codec in data)
            {
                ListViewItem item = new ListViewItem(new [] { codec.FormatDescription, codec.FilenameExtension, codec.CodecName });

                listView1.Items.Add(item);
            }
        }
    }
}