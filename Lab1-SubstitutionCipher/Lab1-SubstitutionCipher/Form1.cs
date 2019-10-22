using System;
using System.Windows.Forms;
using System.Linq;

namespace Lab1_SubstitutionCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateText(string text)
        {
            string letters = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            text = text.ToUpper();

            for (int i = 0; i < text.Length; i++)
            {
                if (letters.IndexOf(text[i]) == -1)
                    return false;
            }

            return true;
        }

        private bool ValidateKey(string key)
        {
            string letters = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string sortedKey = String.Concat(key.OrderBy(c => c)).ToUpper();

            if (letters != sortedKey)
                return false;

            return true;
        }

        private bool ValidateInput(string text, string key)
        {
            if (!ValidateText(text))
            {
                MessageBox.Show("Invalid text. Only letters of the english alphabet and whitespaces allowed!");
                return false;
            }

            if (!ValidateKey(key))
            {
                MessageBox.Show("Invalid key. Make sure you got all the letters of the alphabet only ONCE!");
                return false;
            }

            return true;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string cipherText = "";
            string letters = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string plainText = plainTextBox.Text.ToUpper();

            if (!ValidateInput(plainText, encryptionKeyTextBox.Text))
                return;

            for (int i = 0; i < plainText.Length; i++)
            {
                int index = letters.IndexOf(plainText[i]);
                cipherText += encryptionKeyTextBox.Text[index];
            }

            cipherTextBox.Text = cipherText;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string plainText = "";
            string letters = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cipherText = cipherTextBox.Text;
            string decryptionKey = "";

            if (!ValidateInput(cipherText, encryptionKeyTextBox.Text))
                return;

            for (int i = 0; i < letters.Length; i++)
            {
                int index = encryptionKeyTextBox.Text.IndexOf(letters[i]);
                decryptionKey += letters[index];
            }

            decryptionKeyTextBox.Text = decryptionKey;

            for (int i = 0; i < cipherText.Length; i++)
            {
                int index = letters.IndexOf(cipherText[i]);
                plainText += decryptionKey[index];
            }

            plainTextBox.Text = plainText.ToLower();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            plainTextBox.Clear();
            encryptionKeyTextBox.Clear();
            cipherTextBox.Clear();
            decryptionKeyTextBox.Clear();
        }
    }
}
