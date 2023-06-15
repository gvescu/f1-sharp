using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// This packet details the car setups for each vehicle in the session.
    /// Note that in multiplayer games, other player cars will appear as blank, you will only be able to see your own car setup, regardless of the “Your Telemetry” setting.
    /// Spectators will also not be able to see any car setups.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CarSetupPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// List of car setups
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        public CarSetupData[] carSetups;
    }
}
