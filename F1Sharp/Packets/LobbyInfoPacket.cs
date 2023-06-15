using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// This packet details the players currently in a multiplayer lobby.
    /// It details each player’s selected car, any AI involved in the game and also the ready status of each of the participants.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct LobbyInfoPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Number of players in the lobby
        /// </summary>
        public byte numPlayers;
        /// <summary>
        /// List of players in the lobby
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        public LobbyInfoData[] lobbyPlayers;
    }
}
