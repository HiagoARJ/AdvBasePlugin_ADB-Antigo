using AdvancedBot.Client;
using AdvancedBot.Client.Commands;
using AdvancedBot.Plugins;
using AdvancedBot.Client.Handler;
using System.Windows.Input;

namespace PluginADV
{
    public class PluginADV : IPlugin
    {
        private PluginADVCommand cmdPlugin;

        public void onClientConnect(MinecraftClient client)
        {
            if (client.CmdManager.GetCommand("plugin") == null)
            {
                cmdPlugin = new PluginADVCommand(client);
                client.CmdManager.Commands.Add(new PluginADVCommand(client));
            }
        }

        public void onReceiveChat(string chat, byte pos, MinecraftClient client)
        { }

        public void OnReceivePacket(ReadBuffer pkt, MinecraftClient client)
        { }

        public void onSendChat(string chat, MinecraftClient client)
        { }

        public void OnSendPacket(IPacket packet, MinecraftClient client)
        { }

        public void Tick()
        { }

        public void Unload()
        { }
    }
}
