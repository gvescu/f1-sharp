using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Lap data for a car
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct LapData
    {
        /// <summary>
        /// Last lap time in milliseconds
        /// </summary>
        public uint lastLapTimeInMS;
        /// <summary>
        /// Current time around the lap in milliseconds
        /// </summary>
        public uint currentLapTimeInMS;
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
        /// Time delta to car in front in milliseconds
        /// </summary>
        public ushort deltaToCarInFrontInMS;
        /// <summary>
        /// Time delta to race leader in milliseconds
        /// </summary>
        public ushort deltaToRaceLeaderInMS;
        /// <summary>
        /// Distance car is around the current lap in meters.
        /// Could be negative if line hasn't been crossed yet.
        /// </summary>
        public float lapDistance;
        /// <summary>
        /// Total distance travelled in session in meters.
        /// Could be negative if line hasn't been crossed yet.
        /// </summary>
        public float totalDistance;
        /// <summary>
        /// Delta in seconds for safety car
        /// </summary>
        public float safetyCarDelta;
        /// <summary>
        /// Car race position
        /// </summary>
        public byte carPosition;
        /// <summary>
        /// Current lap number
        /// </summary>
        public byte currentLapNum;
        /// <summary>
        /// Pit status of the car
        /// </summary>
        public PitStatus pitStatus;
        /// <summary>
        /// Number of pit stops taken in this race
        /// </summary>
        public byte numPitStops;
        /// <summary>
        /// Sector the car is in
        /// </summary>
        public Sector sector;
        /// <summary>
        /// Indicates if the current lap is invalid
        /// 0 = valid; 1 = invalid
        /// </summary>
        public byte currentLapInvalid;
        /// <summary>
        /// Accumulated time penalties in seconds to be added
        /// </summary>
        public byte penalties;
        /// <summary>
        /// Accumulated number of warnings issued
        /// </summary>
        public byte totalWarnings;
        /// <summary>
        /// Accumulated number of corner cutting warnings issued
        /// </summary>
        public byte cornerCuttingWarnings;
        /// <summary>
        /// Number of drive through penalties left to serve
        /// </summary>
        public byte numUnservedDriveThroughPens;
        /// <summary>
        /// Number of stop &amp; go penalties left to serve
        /// </summary>
        public byte numUnservedStopGoPens;
        /// <summary>
        /// Grid position the car started the race in
        /// </summary>
        public byte gridPosition;
        /// <summary>
        /// Status of the driver
        /// </summary>
        public DriverStatus driverStatus;
        /// <summary>
        /// Result of the driver
        /// </summary>
        public ResultStatus resultStatus;
        /// <summary>
        /// Pit lane timing
        /// 0 = inactive; 1 = active
        /// </summary>
        public byte pitLaneTimerActive;
        /// <summary>
        /// If timer is active, the current time spent in the pit lane in milliseconds
        /// </summary>
        public ushort pitLaneTimeInLaneInMS;
        /// <summary>
        /// Time of the actual pit stop in milliseconds
        /// </summary>
        public ushort pitStopTimerInMS;
        /// <summary>
        /// Whether the car should serve a penalty at this stop
        /// </summary>
        public byte pitStopShouldServePen;
    }
}
