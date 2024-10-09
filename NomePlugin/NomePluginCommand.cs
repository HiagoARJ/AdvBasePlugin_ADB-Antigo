using System;
using System.Linq;
using AdvancedBot.Client.Map;
using AdvancedBot.Client.Packets;
using AdvancedBot.Client.Commands;

namespace AdvancedBot.Client.Commands
{
    class PluginADVCommand : ICommand
    {

        private bool isToggled;
        private readonly MinecraftClient client;

        public PluginADVCommand(MinecraftClient cli)
        : base(cli, "Plugin", "Descrição do Plugin", "plugin")
        {
            isToggled = false;
            client = cli;
        }

        public override CommandResult Run(string alias, string[] args)
        {

            Toggle();
            if (!isToggled)
            {
                Client.PrintToChat("§fPlugin: §c§lDesativado§f.");
            }
            else
            {
                Client.PrintToChat("§fPlugin: §a§lAtivado§f.");
            }
            return CommandResult.Success;
        }

        public override void Tick()
        {
            if (isToggled) // Execute apenas se ainda não tiver executado
            {
                //Local dos códigos de programação
            }
        }

        private void Toggle()
        {
            isToggled = !isToggled;
        }

    }

}
