using System;
using System.Windows.Forms;

namespace Text_Converter
{
    public partial class UTF16toHex : Form
    {
        public UTF16toHex()
        {
            InitializeComponent();

            //TextBox Setting
            this.ResultTextBox.CharacterCasing = CharacterCasing.Upper;
            this.ResultTextBox.ReadOnly = true;
        }

        public string ToHex(string inp)
        {
            string outp = string.Empty;
            char[] value = inp.ToCharArray();
            foreach (char L in value)
            {
                int V = Convert.ToInt32(L);
                outp += string.Format("00" + "{00:x}", V);
            }
            return outp;
        }

    private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.InputTextBox.Text.Length == 0)
                {
                    this.ResultTextBox.Text = null;
                }
                else
                {
                    this.ResultTextBox.Text = ToHex(InputTextBox.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Text Conversion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.SelectAll();
            //and
            ResultTextBox.Copy();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
