using Microsoft.VisualBasic.Logging;

namespace Zadanie06
{
    public partial class Form1 : Form
    {
        private ListViewItem[] tempListCollection;
        public Form1()
        {
            InitializeComponent();
            appendColums();
            appendItems();
        }

        private void appendColums()
        {
            listView1.Columns.Add("Imie");
            listView1.Columns.Add("Nazwisko");
            listView1.Columns.Add("Nr. Tel.");
            listView1.Columns.Add("Ulica");
            listView1.Columns.Add("Miasto");
        }

        private void appendItems()
        {
            var item1 = new ListViewItem(new[] { "Kamil", "Wojciechowski", "123456789", "ulica 1", "jakas" });
            var item2 = new ListViewItem(new[] { "Test1", "Test2", "987654321", "ulica 2", "cosasd" });
            var item3 = new ListViewItem(new[] { "Test4", "Test5", "987654321", "ulica 2", "cosasd" });
            ListViewItem[] listViewRange = new ListViewItem[] { item1, item2, item3 };
            listView1.Items.AddRange(listViewRange);
            tempListCollection = listViewRange; 
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView lv = (ListView)sender;

            if (lv.Tag == null || (int)lv.Tag > 0)
            {
                ListViewItem[] tmp = lv.Items.Cast<ListViewItem>().OrderBy(t => t.SubItems[e.Column].Text).ToArray();
                lv.Items.Clear();
                lv.Items.AddRange(tmp);

                lv.Tag = -1;
            }
            else
            {
                ListViewItem[] tmp = lv.Items.Cast<ListViewItem>().OrderByDescending(t => t.SubItems[e.Column].Text).ToArray();
                lv.Items.Clear();
                lv.Items.AddRange(tmp);

                lv.Tag = +1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListView lv = listView1;

            if (lv.Items.Count < tempListCollection.Length)
            {
                lv.Items.Clear();
                lv.Items.AddRange(tempListCollection);
            }
            

            if (textBox1.Text.Length > 0)
            {
                var item = lv.FindItemWithText(textBox1.Text);
                if (item != null)
                {
                    lv.Items.Clear();
                    lv.Items.Add(item);
                }
            }
        }
    }
}