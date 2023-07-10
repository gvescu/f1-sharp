using F1Sharp.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// The lap data packet gives details of all the cars in the session.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct LapDataPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Lap data for all cars on track
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        public LapData[] lapData;
        /// <summary>
        /// Index of Personal Best car in time trial (255 if invalid)
        /// </summary>
        public byte timeTrialPBCarIdx;
        /// <summary>
        /// Index of Rival Car in time trial (255 if invalid)
        /// </summary>
        public byte timeTrialRivalCarIdx;
    }
}
