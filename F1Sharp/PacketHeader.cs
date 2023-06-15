using System.Runtime.InteropServices;

namespace F1Sharp
{
    /// <summary>
    /// Every packet sent by the game has this header
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct PacketHeader
    {
        /// <summary>
        /// Format of the packet. 2023 is the current one.
        /// </summary>
        public ushort packetFormat;
        /// <summary>
        /// Last two digits of the game year
        /// </summary>
        public byte gameYear;
        /// <summary>
        /// Game major version
        /// </summary>
        public byte gameMajorVersion;
        /// <summary>
        /// Game minor version
        /// </summary>
        public byte gameMinorVersion;
        /// <summary>
        /// Version of this packet type
        /// </summary>
        public byte packetVersion;
        /// <summary>
        /// Identifier for the packet type
        /// </summary>
        public Packet packetId;
        /// <summary>
        /// Unique identifier for the session
        /// </summary>
        public ulong sessionUID;
        /// <summary>
        /// Session timestamp
        /// </summary>
        public float sessionTime;
        /// <summary>
        /// Identifier for the frame the data was retrieved from
        /// </summary>
        public uint frameIdentifier;
        /// <summary>
        /// Overall identifier for the frame the data was retrieved from
        /// (doesn't go back after flashbacks)
        /// </summary>
        public uint overallFrameIdentifier;
        /// <summary>
        /// Index of the player's car in the car array
        /// </summary>
        public byte playerCarIndex;
        /// <summary>
        /// Index of the secondary player's car in the car array (splitscreen).
        /// 255 if no second player
        /// </summary>
        public byte secondaryPlayerCarIndex;
    }
}