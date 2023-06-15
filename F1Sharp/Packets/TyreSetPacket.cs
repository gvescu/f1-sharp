using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// This packets gives a more in-depth details about tyre sets assigned to a vehicle during the session.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TyreSetPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Index of the car the data relates to
        /// </summary>
        public byte carIdx;
        /// <summary>
        /// Tyre set data
        /// 13 dry + 7 wet
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public TyreSetData[] data;
        /// <summary>
        /// Index into array of fitted tyre
        /// </summary>
        public byte fittedIdx;
    }
}
