using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// <para>This packet contains lap times and tyre usage for the session.</para>
    /// <para>This packet works slightly differently to other packets.
    /// To reduce CPU and bandwidth, each packet relates to a specific vehicle and is sent every 1/20 s, and the vehicle being sent is cycled through.
    /// Therefore in a 20 car race you should receive an update for each vehicle at least once per second.</para>
    /// <para>Note that at the end of the race, after the final classification packet has been sent, a final bulk update of all the session histories for the vehicles in that session will be sent.</para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SessionHistoryPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Index of the car this lap data relates to
        /// </summary>
        public byte carIdx;
        /// <summary>
        /// Number of laps in the data (including current partial lap)
        /// </summary>
        public byte numLaps;
        /// <summary>
        /// Number of tyre stints in the data
        /// </summary>
        public byte numTyreStints;
        /// <summary>
        /// Lap the best lap time was achieved on
        /// </summary>
        public byte bestLapTimeLapNum;
        /// <summary>
        /// Lap the best sector 1 time was achieved on
        /// </summary>
        public byte bestSector1Lapnum;
        /// <summary>
        /// Lap the best sector 2 time was achieved on
        /// </summary>
        public byte bestSector2Lapnum;
        /// <summary>
        /// Lap the best sector 3 time was achieved on
        /// </summary>
        public byte bestSector3Lapnum;
        /// <summary>
        /// Lap history. 100 laps max.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public LapHistoryData[] lapHistoryData;
        /// <summary>
        /// Stint history
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public TyreStintHistoryData[] tyreStintHistoryData;
    }
}
