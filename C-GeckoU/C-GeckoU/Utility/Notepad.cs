using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace C_GeckoU.Utility
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void TextEditorButton_Click(object sender, EventArgs e)
        {
            Process.Start("Notepad.exe");
        }
    }
}
