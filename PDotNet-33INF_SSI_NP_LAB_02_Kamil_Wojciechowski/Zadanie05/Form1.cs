namespace Zadanie05
{
    public partial class Form1 : Form
    {
        private Int32 selected;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button1.Enabled = false;
            listBox1.Items.Add("Test1");
            listBox1.Items.Add("Test2");
            listBox1.Items.Add("Test3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                button2.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}