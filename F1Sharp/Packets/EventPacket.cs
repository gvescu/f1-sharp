using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// This packet gives details of events that happen during the course of a session.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct EventPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Event string code
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public char[] eventStringCode;
        /// <summary>
        /// Event details. Should be parsed differently for each event code.
        /// </summary>
        public EventDetails eventDetails;
    }
}
