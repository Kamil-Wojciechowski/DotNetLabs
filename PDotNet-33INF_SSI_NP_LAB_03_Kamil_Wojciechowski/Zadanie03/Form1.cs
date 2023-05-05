using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;


namespace Zadanie03
{
    public partial class Form1 : Form
    {

        private RSAParameters _publicKey;
        private RSAParameters _privateKey;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void generateKeys(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);

            _publicKey = rsa.ExportParameters(false);
            _privateKey = rsa.ExportParameters(true);

            publicKey.Text = Convert.ToBase64String(_publicKey.Modulus);
            privateKey.Text = Convert.ToBase64String(_privateKey.D);

        }

        private void encryptText(object sender, EventArgs e)
        {
            byte[] plainText = Encoding.UTF8.GetBytes(textEncDec.Text);

            BigInteger result = BigInteger.ModPow(new BigInteger(plainText), new BigInteger(_publicKey.Exponent), new BigInteger(_publicKey.Modulus));

            resultTextBox.Text = result.ToString();
        }

        private void decryptText(object sender, EventArgs e)
        {
            BigInteger plainText = BigInteger.Parse(textEncDec.Text);

            byte[] decryptedBytes = BigInteger.ModPow(plainText, new BigInteger(_privateKey.D), new BigInteger(_privateKey.Modulus)).ToByteArray();

            string decryptedString = Encoding.UTF8.GetString(decryptedBytes);

            resultTextBox.Text = decryptedString;
        }
    }
}