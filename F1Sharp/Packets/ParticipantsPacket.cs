using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// This is a list of participants in the race.
    /// If the vehicle is controlled by AI, then the name will be the driver name.
    /// If this is a multiplayer game, the names will be the Steam Id on PC, or the LAN name if appropriate.
    /// On Xbox, the names will always be the driver name.
    /// On PlayStation the name will be the LAN name if playing a LAN game, otherwise it will be the driver name.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ParticipantsPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Number of active cars (should match number of cars in HUD)
        /// </summary>
        public byte numActiveCars;
        /// <summary>
        /// List of participants
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        public ParticipantData[] participants;
    }
}
