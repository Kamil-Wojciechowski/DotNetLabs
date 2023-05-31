using System.Drawing.Printing;

namespace Zadanie08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Nazwa");
            listView1.Columns.Add("Cena");
            listView1.Columns.Add("Opis");

            listView1.Items.Add(new ListViewItem(new[] { "Produkt 1", "100", "Opis produktu 1" }));
            listView1.Items.Add(new ListViewItem(new[] { "Produkt 2", "200", "Opis produktu 2" }));
            listView1.Items.Add(new ListViewItem(new[] { "Produkt 3", "300", "Opis produktu 3" }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings.PrinterSettings.PrintRange = printDialog.PrinterSettings.PrintRange;

                if (printDialog.PrinterSettings.PrintRange == PrintRange.SomePages)
                {
                    printDocument.PrinterSettings.FromPage = printDialog.PrinterSettings.FromPage;
                    printDocument.PrinterSettings.ToPage = printDialog.PrinterSettings.ToPage;
                }

                PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            float marginLeft = e.MarginBounds.Left;
            float marginTop = e.MarginBounds.Top;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected)
                {
                    e.Graphics.DrawString(item.SubItems[0].Text + "|" + item.SubItems[1].Text + "|" + item.SubItems[2].Text, font, Brushes.Black, marginLeft, marginTop);

                    marginTop += font.GetHeight();

                    if (marginTop >= e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }
            }

            e.HasMorePages = false;
        }
    }
}