using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyxBuilderGUI.Handler
{
    internal class Discord
    {
        public static DiscordRpcClient client;

        public static void Start()
        {
            try
            {
                client = new DiscordRpcClient("995759217875091526");
                client.Initialize();
                client.SetPresence(new RichPresence()
                {
                    Details = $"Nyx Builder",
                    State = $"Idle",
                    Assets = new Assets()
                    {
                        LargeImageKey = "nyx",
                        LargeImageText = "https://github.com/ping-127001/NyxBuilder",
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error starting Discord RPC. Error: {ex.Message}");
            }
        }

        public static void Update(string State)
        {
            if (client.IsInitialized)
            {
                try
                {
                    client.SetPresence(new RichPresence()
                    {
                        Details = $"Nyx Builder",
                        State = State,
                        Assets = new Assets()
                        {
                            LargeImageKey = "nyx",
                            LargeImageText = "https://github.com/ping-127001/NyxBuilder",
                        }
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"There was an error updating Discord RPC. Error: {ex.Message}");
                }
            }
        }

        public static void Close()
        {
            if (client.IsInitialized)
            {
                client.Dispose();
            }
        }
    }
}
