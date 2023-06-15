using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Final classification data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FinalClassificationData
    {
        /// <summary>
        /// Finishing position
        /// </summary>
        public byte position;
        /// <summary>
        /// Number of laps completed
        /// </summary>
        public byte numLaps;
        /// <summary>
        /// Starting grid position
        /// </summary>
        public byte gridPosition;
        /// <summary>
        /// Number of points scored
        /// </summary>
        public byte points;
        /// <summary>
        /// Number of pit stops made
        /// </summary>
        public byte numPitStops;
        /// <summary>
        /// Result status
        /// </summary>
        public ResultStatus resultStatus;
        /// <summary>
        /// Best lap time of the session in milliseconds
        /// </summary>
        public uint bestLapTimeInMS;
        /// <summary>
        /// Total race time in seconds without penalties
        /// </summary>
        public double totalRaceTime;
        /// <summary>
        /// Total penalties acumulated in seconds
        /// </summary>
        public byte penaltiesTime;
        /// <summary>
        /// Number of penalties applied to this driver
        /// </summary>
        public byte numPenalties;
        /// <summary>
        /// Number of tyre stints up to maximum
        /// </summary>
        public byte numTyreStings;
        /// <summary>
        /// Actual tyres used by this driver
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public TyreCompound[] tyreStintsActual;
        /// <summary>
        /// Visual tyres used by this driver
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public VisualTyreCompound[] tyreStintsVisual;
        /// <summary>
        /// The lap number the stints end on
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] tyreStintsEndLaps;
    }
}
