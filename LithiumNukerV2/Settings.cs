﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// All of the settings can be changed from here

namespace LithiumNukerV2
{
    public class Settings
    {
        public static bool Debug = false;
        
        public static readonly string Logo = @"
            ▒▒▒          ░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ▒░▒▒▒      ▒▒▒                                 ▒░░░▒
          ▒▒██▒         ▒▒▒▒▒░▒███████████████████░▒▒▒▒▒▒▒████▒     ▒▒▒█▒       ▒▒▒     ▒▒     ▒ ▒      ▒████▒
        ▒█████▒        ▒████▒   ▒▒▒▒▒█████▒▒       ▒▒░▒▒▒▒████▒    ▒████▒    ░▒▒░░▒   ▒░█▒   ▒░▒░▒      ▒████▒
       ▒█████▒        ▒▒████▒      ░▒████▒▒      ▒░███▒▒▒█████▒   ▒▒████▒   ▒████▒   ▒██▒▒  ▒▒███▒▒    ▒████▒▒
      ▒▒████▒         ▒████▒▒      ▒████░▒      ▒░████▒▒▒████▒    ▒████▒▒   ▒███▒  ▒▒███▒   ▒█████▒ ▒▒█████▒▒
     ░▒████▒          ▒████▒      ▒▒████▒   ▒▒▒░█████▒▒▒████▒▒    ▒████▒  ▒▒███▒▒  ▒████▒   ▒█████▒▒██████▒▒
     ▒░████▒         ░▒███▒       ▒███░▒   ▒▒▒░████████████▒▒▒▒  ▒▒███▒   ▒████▒  ▒█████▒  ▒░████████████▒▒
     ▒████▒          ▒▒███▒      ▒░███▒▒      ▒████▒▒▒▒████▒▒▒   ▒▒██░▒   ▒███▒  ▒▒████▒   ▒███▒▒███▒▒███▒
  ▒▒▒█████▒▒░░░▒░█░▒▒▒███▒       ▒▒██▒▒      ░▒███▒  ▒███▒▒      ▒███▒    ▒███▒ ▒▒████▒   ▒▒███▒▒▒█▒░▒██▒▒
 ░ ░▒█████████████░▒▒▒██▒▒       ▒███▒       ▒███▒▒  ▒███▒       ▒██▒▒    ▒░█████████▒▒   ▒██▒▒▒░▒▒▒▒▒█▒▒
   ▒▒▒░░▒▒▒▒▒▒       ▒░▒▒        ▒░██▒       ▒██░▒   ▒██▒░       ▒░▒░       ▒░█████░▒     ▒█▒       ▒░▒▒
                    ▒░▒          ▒▒█▒        ▒█▒▒   ▒░▒▒        ▒▒▒                                 ▒▒▒
                                 ▒░▒▒       ▒▒▒     ▒▒░
                                 ▒▒▒";
        public static string Token;
        public static long? GuildId = null;
        public static int Threads = 40;
        public static int ConnectionLimit = 25; // 10 concurrent connections
        public static readonly string WebhookName = "jynx x anti runs you nigger";
        public static readonly string AvatarUrl = "https://camo.githubusercontent.com/450b75468a748fbd8e4b3116c378cc9cfdcadd8b0b0e676821a6f873fcb85f53/68747470733a2f2f7665726c6f782e63632f7261772f535865475144";
    }
}
