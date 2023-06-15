using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// The motion packet gives physical data for all the cars being driven.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MotionPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Motion data for all cars on track
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        public MotionData[] carMotionData;
    }
}
