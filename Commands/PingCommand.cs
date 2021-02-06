﻿using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiliconBot.Commands
{
    public class PingCommand : Command
    {
        public override string Name => "ping";

        public override async Task Code(DiscordMessage msg, string[] args) => await msg.RespondAsync("Pong!");
    }
}