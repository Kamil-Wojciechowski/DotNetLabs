using System.Windows.Forms;
using System.Xml;

namespace Zadanie07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            readFile.Click += ReadFileOnClick;
            clearFile.Click += ClearFileOnClick;
            import.Click += ImportOnClick;

            openFileDialog1.Filter = "XML files (*.xml)|*.xml"; ;
        }

        private void ImportOnClick(object? sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(filename.Text.ToString()))
            {
                LoadPeopleXml(filename.Text.ToString());
            }
        }

        private void LoadPeopleXml(string filePath)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(filePath);

            TreeNode rootNode = new TreeNode("People");
            XmlNodeList personNodes = xmlDocument.SelectNodes("//person");

            foreach (XmlNode personNode in personNodes)
            {
                string firstName = personNode.ChildNodes.Item(0).InnerText;
                string lastName = personNode.ChildNodes.Item(1).InnerText;

                TreeNode person = new TreeNode(firstName + " " + lastName);
                
                rootNode.Nodes.Add(person);
            }

            treeView1.Nodes.Add(rootNode);
        }

        private void ClearFileOnClick(object? sender, EventArgs e)
        {
            filename.Text = string.Empty;
        }

        private void ReadFileOnClick(object? sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename.Text = openFileDialog1.FileName;
            }
        }
    }
}