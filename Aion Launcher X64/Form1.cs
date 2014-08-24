using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Aion_Launcher_X64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
;

            // Use ProcessStartInfo class
            string argu = @"-ip:79.110.83.80 -port:2106 -noweb -noauthgg -st -charnamemenu -ingamebrowser -webshopevent:2 -f2p -lbox /SessKey:"""" /CompanyID:""11"" /ChannelGroupIndex:""-1""  -lang:ENG";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "C:/Program Files (x86)/GameforgeLive/Games/GBR_eng/AION/Download/bin64/aion.bin";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            // No Aion Shop........ startInfo.Arguments = "-ip:79.110.83.80 -port:2106 -cc:2 -noauthgg -ls -charnamemenu -lang:eng -lbox -f2p";
            startInfo.Arguments = argu;
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    Environment.Exit(0);
                }
            }
            catch
            {
                // Log error.
            }
        }
    }
}
