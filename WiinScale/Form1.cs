using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;

namespace WiinScale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Task.Run(() =>
            {
                int connected = 0;
                while (connected == 0)
                {
                    ConnectionStatus.BeginInvoke((Action)(() => {
                        ConnectionStatus.Text = "Connecting...";
                    }));

                    while ((connected = WiiUseBoard.Init()) == 0)
                        System.Threading.Thread.Sleep(500);

                    ConnectionStatus.BeginInvoke((Action)(() => {
                        ConnectionStatus.Text = "Connected";
                    }));

                    float weight, x, y;
                    while ((connected = WiiUseBoard.Read(out weight, out x, out y)) != 0)
                    {
                        Weight.BeginInvoke((Action)(() => {
                            Weight.Text = string.Format("{0:00.00} Kg", weight);
                        }));
                        System.Threading.Thread.Sleep(50);
                    }

                    WiiUseBoard.Shutdown();
                }
            });
        }
    }

    public static class WiiUseBoard
    {
        [DllImport("wiiuse_board.dll", EntryPoint = "wiiuse_board_init")]
        public extern static int Init();
        [DllImport("wiiuse_board.dll", EntryPoint = "wiiuse_board_read")]
        public extern static int Read(out float weight, out float x, out float y);
        [DllImport("wiiuse_board.dll", EntryPoint = "wiiuse_board_shutdown")]
        public extern static void Shutdown();
    }
}
