using C_GeckoU.Utility;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using TCPGeckoSharp;
using Text_Converter;

namespace C_GeckoU
{
    public partial class Source : Form
    {
        public Source()
        {
            InitializeComponent();
        }

        /*------------------------------------------------------------------------*/

        public TCPGecko gecko;

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            this.gecko = new TCPGecko(IPv4TextBox.Text, 7331);

            string disc = "Disconnect";

            try
            {
                this.gecko.Connect();
                Console.WriteLine("Connected Successfully");

                this.ConnectButton.Text = disc;
            }
            catch (ETCPGeckoException ex)
            {
                MessageBox.Show(ex.Message, "C Gecko U", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "C Gecko U", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (this.ConnectButton.Text == disc)
            {
                try
                {
                    this.gecko.Disconnect();
                    Console.WriteLine("Disconnected Successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "C Gecko U", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                }
            }
        }

        private void SendCodesButton_Click(object sender, EventArgs e)
        {
            //None
        }

        private void DiableCodesButton_Click(object sender, EventArgs e)
        {
            //None
        }

        private void NotepadButton_Click(object sender, EventArgs e)
        {
            Notepad Notepad = new Notepad();
            Notepad.Show();
        }

        /*------------------------------------------------------------------------*/

        private void UTF16toHex_Click(object sender, EventArgs e)
        {
            UTF16toHex Hex = new UTF16toHex();
            Hex.Show();
        }

        /*------------------------------------------------------------------------*/

        private static void GetIPv4Address(string hostname)
        {
            string hostName = Dns.GetHostName();

            IPHostEntry ipHostEntry = Dns.GetHostEntry(hostName);
            ipHostEntry.AddressList.Where(x => x.AddressFamily == AddressFamily.InterNetwork).FirstOrDefault().ToString();
        }

        [Obsolete]

        private void LocalIPAddressButton_Click(object sender, EventArgs e)
        {
            var nL = Environment.NewLine;

            string hostName = Dns.GetHostName();
            string IPv4 = Dns.GetHostByName(hostName).AddressList[0].ToString();

            var Result = MessageBox.Show("! " + IPv4,"Your Computer IPv4", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /*------------------------------------------------------------------------*/

        private void BuildDataButton_Click(object sender, EventArgs e)
        {
            DateTime NewDate = DateTime.Now;
            MessageBox.Show(NewDate.ToString() + " 日本標準時","Build Date", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        /*------------------------------------------------------------------------*/

        private void BugTrackerButton_Click(object sender, EventArgs e)
        {
            var issues = "https://github.com/Pop-Apple/JGeckoU-Reproduction/issues";
            Process.Start(issues);
        }

        /*------------------------------------------------------------------------*/

        private void DocumentButton_Click(object sender, EventArgs e)
        {
            var document = "http://web.archive.org/web/20171108014746/http://cosmocortney.ddns.net:80/enzy/cafe_code_types_en.php#asm";
            Process.Start(document);
        }

        /*------------------------------------------------------------------------*/

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            var WiiUPlaza = "https://github.com/MinecraftWiiUCodes/MinecraftWiiUPlaza";
            Process.Start(WiiUPlaza);
        }

        /*------------------------------------------------------------------------*/

        private void IPv4TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double address = Convert.ToDouble(IPv4TextBox.Text);
            }
            catch(Exception)
            {
                this.IPv4TextBox.BackColor = Color.Red;
            }

            //192.168.x.x
            if (this.IPv4TextBox.Text.Length > 10)
            {
                IPv4TextBox.BackColor = Color.Lime;
            }
            else
            {
                IPv4TextBox.BackColor = Color.Red;
            }
        }

        /*------------------------------------------------------------------------*/

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpDialog hd = new HelpDialog();
            try
            {
                hd.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*------------------------------------------------------------------------*/

        private void DownloadTCPGecko_Click(object sender, EventArgs e)
        {
            var TCPGeckoInstaller = "https://github.com/BullyWiiPlaza/tcpgecko";
            Process.Start(TCPGeckoInstaller);
        }

        private void DownloadJGeckoU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var JGeckoU = "https://github.com/BullyWiiPlaza/JGeckoU";
            Process.Start(JGeckoU);
        }

        private void DownloadCGeckoU_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var CGeckoU = "https://github.com/Pop-Apple/JGeckoU-Reproduction";
            Process.Start(CGeckoU);
        }

        private void DownloadQtGecko_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var QtGecko = "https://github.com/Korozin/QtGecko";
            Process.Start(QtGecko);
        }

        /*------------------------------------------------------------------------*/
    }
}
