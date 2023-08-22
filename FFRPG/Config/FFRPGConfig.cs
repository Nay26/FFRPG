using System.Collections.Generic;

namespace FFRPG
{
    public class FFRPGConfig
    {
        public int MaxRoll { get; set; } = 999;

        public Dictionary<string, string> Messages = new Dictionary<string, string>() {
            { "RoundStart", " Starting a New Round!  <se.12>" },
            { "PlayerRolled", "\" #player#  Rolls a #roll#\" " },
            { "PlayerRolled69", "\" #player#  Rolls a #roll#. Nice.\"" },
            { "WinMessage", "\" #winner#  Asks  #loser#  Truth or Dare!\"" },
            { "StatMostWins", "\" #player#  has been working overtime with #mostwins# wins!\"" },
            { "StatMostLosses", "\" #player#  is the biggest bottom with #mostlosses# losses!\"" },
            { "StatBiggestRivals", "\" #rival1#  and  #rival2#  have been paired the most times! Current score #rival1Wins# : #rival2Wins#!\""},
        };
    }
}
