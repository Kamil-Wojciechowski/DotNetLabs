using System.Drawing.Imaging;

namespace Zadanie09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        public class ImageForm : Form
        {
            public Image Image { get; set; }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                if (Image != null)
                {
                    e.Graphics.DrawImage(Image, 0, 0);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki graficzne (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImageForm imageForm = new ImageForm();
                    imageForm.MdiParent = this;
                    imageForm.Image = Image.FromFile(openFileDialog.FileName);
                    imageForm.Show();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }

            }
        }
    }
}