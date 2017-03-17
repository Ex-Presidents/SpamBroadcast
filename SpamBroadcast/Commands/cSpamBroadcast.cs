using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Unturned.Player;
using Rocket.Unturned.Chat;
using Rocket.Core.Logging;
using Rocket.API.Extensions;

namespace SpamBroadcast.Commands
{
    public class cSpamBroadcast : IRocketCommand
    {
        #region Properties
        public AllowedCaller AllowedCaller { get { return AllowedCaller.Both; } }
        public string Name { get { return "spambroadcast"; } }
        public string Help { get { return "Spams a broadcast message as many times as specified"; } }
        public string Syntax { get { return "/spambroadcast [Times to broadcast] [Message]"; } }
        public List<string> Aliases { get { return new List<string>() { "sb" }; } }
        public List<string> Permissions { get { return new List<string>() { "broadcast", "spambroadcast" }; } }
        #endregion

        public void Execute(IRocketPlayer caller, string[] command)
        {
            int repeat;

            if (command.Length < 2)
            {
                UnturnedChat.Say(caller, Syntax);
                return;
            }
            if (!int.TryParse(command[0], out repeat))
            {
                UnturnedChat.Say(caller, Syntax);
                return;
            }

            while (repeat > 0)
            {
                UnturnedChat.Say(command.GetParameterString(1));
                repeat--;
            }
        }
    }
}
