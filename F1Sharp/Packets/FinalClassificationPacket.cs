using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// his packet details the final classification at the end of the race, and the data will match with the post race results screen.
    /// This is especially useful for multiplayer games where it is not always possible to send lap times on the final frame because of network delay.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FinalClassificationPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Number of cars in the final classification
        /// </summary>
        public byte numCars;
        /// <summary>
        /// List of cars
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        public FinalClassificationData[] classificationData;
    }
}
