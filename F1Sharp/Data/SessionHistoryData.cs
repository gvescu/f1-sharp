using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Lap history data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct LapHistoryData
    {
        /// <summary>
        /// Lap time in milliseconds
        /// </summary>
        public uint lapTimeInMS;
        /// <summary>
        /// Sector 1 time in milliseconds
        /// </summary>
        public ushort sector1TimeInMS;
        /// <summary>
        /// Sector 1 whole minute part
        /// </summary>
        public byte sector1TimeMinutes;
        /// <summary>
        /// Sector 2 time in milliseconds
        /// </summary>
        public ushort sector2TimeInMS;
        /// <summary>
        /// Sector 2 whole minute part
        /// </summary>
        public byte sector2TimeMinutes;
        /// <summary>
        /// Sector 3 time in milliseconds
        /// </summary>
        public ushort sector3TimeInMS;
        /// <summary>
        /// Sector 3 whole minute part
        /// </summary>
        public byte sector3TimeMinutes;
        /// <summary>
        /// Bit flags
        /// 0x01 bit set = lap valid; 0x02 bit set = sector 1 valid;
        /// 0x04 bit set = sector 2 valid; 0x08 bit set = sector 3 valid
        /// </summary>
        public byte lapValidBitFlags;
    }

    /// <summary>
    /// Tyre stint history data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TyreStintHistoryData
    {
        /// <summary>
        /// Lap the tyre usage ends on
        /// </summary>
        public byte endLap;
        /// <summary>
        /// Actual tyres used by the driver
        /// </summary>
        public TyreCompound tyreActualCompound;
        /// <summary>
        /// Visual tyres used by the driver
        /// </summary>
        public VisualTyreCompound tyreVisualCompound;
    }
}
