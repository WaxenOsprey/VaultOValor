// Purpose: To hold the Party class.
using System;

namespace models
{
    public class Party
    {
        public int PartyId { get; set; }
        public string PartyName { get; set; }
        public List<Player> Members { get; set; }

        public Party(int partyId, string partyName, List<Player> members)
        {
            PartyId = partyId;
            PartyName = partyName;
            Members = members;
        }

        public void addPlayer(Player player)
        {
            Members.Add(player);
        }

        public void removePlayer(Player player)
        {
            Members.Remove(player);
        }

        public void updatePartyName(string newName)
        {
            PartyName = newName;
        }
    }
}