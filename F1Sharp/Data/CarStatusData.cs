using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Car status data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CarStatusData
    {
        /// <summary>
        /// Traction control level
        /// 0 = off; 1 = medium; 2 = full
        /// </summary>
        public byte tractionControl;
        /// <summary>
        /// ABS status
        /// 0 = off; 1 = on
        /// </summary>
        public byte antilockBrakes;
        /// <summary>
        /// Current fuel mix
        /// 0 = lean; 1 = standard; 2 = rich; 3 = max
        /// </summary>
        public byte fuelMix;
        /// <summary>
        /// Front brake bias (percentage)
        /// </summary>
        public byte frontBrakeBias;
        /// <summary>
        /// Pit limiter status
        /// 0 = off; 1 = on
        /// </summary>
        public byte pitLimiterStatus;
        /// <summary>
        /// Current fuel mass
        /// </summary>
        public float fuelInTank;
        /// <summary>
        /// Fuel capacity
        /// </summary>
        public float fuelCapacity;
        /// <summary>
        /// Fuel remaining in terms of laps (value on MFD)
        /// </summary>
        public float fuelRemainingLaps;
        /// <summary>
        /// Car's max RPM, point of rev limiter
        /// </summary>
        public ushort maxRPM;
        /// <summary>
        /// Car's idle RPM
        /// </summary>
        public ushort idleRPM;
        /// <summary>
        /// Maximum number of gears
        /// </summary>
        public byte maxGears;
        /// <summary>
        /// Whether the DRS is allowed
        /// 0 = not allowed; 1 = allowed
        /// </summary>
        public byte drsAllowed;
        /// <summary>
        /// Distance where DRS will be available
        /// 0 = not available; non-zero = distance in meters
        /// </summary>
        public ushort drsActivationDistance;
        /// <summary>
        /// Tyre compound
        /// </summary>
        public TyreCompound actualTyreCompound;
        /// <summary>
        /// Visual tyre compound
        /// </summary>
        public VisualTyreCompound visualTyreCompound;
        /// <summary>
        /// Age in laps of current set of tyres
        /// </summary>
        public byte tyresAgeLaps;
        /// <summary>
        /// Flags shown to the car
        /// </summary>
        public ZoneFlag vehicleFiaFlags;
        /// <summary>
        /// Engine power output of ICE in watts
        /// </summary>
        public float enginePowerICE;
        /// <summary>
        /// Engine power output of MGU-K in watts
        /// </summary>
        public float enginePowerMGUK;
        /// <summary>
        /// ERS energy store in joules
        /// </summary>
        public float ersStoreEnergy;
        /// <summary>
        /// ERS deployment mode
        /// 0 = none; 1 = medium; 2 = hotlap; 3 = overtake
        /// </summary>
        public byte ersDeployMode;
        /// <summary>
        /// Energy harvested this lap by the MGU-K
        /// </summary>
        public float ersHarvestedThisLapMGUK;
        /// <summary>
        /// Energy harvested this lap by the MGU-H
        /// </summary>
        public float ersHarvestedThisLapMGUH;
        /// <summary>
        /// ERS energy deployed this lap
        /// </summary>
        public float ersDeployedThisLap;
        /// <summary>
        /// Whether the car is paused in a network game
        /// </summary>
        public byte networkPaused;
    }
}
