using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Car telemetry data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CarTelemetryData
    {
        /// <summary>
        /// Speed in kilometers per hour
        /// </summary>
        public ushort speed;
        /// <summary>
        /// Amount of throttle applied (0..1)
        /// </summary>
        public float throttle;
        /// <summary>
        /// Amount of steering applied (-1...1)
        /// 0 = neutral; -1 = full lock left; 1 = full lock right
        /// </summary>
        public float steer;
        /// <summary>
        /// Amount of brake applied (0..1)
        /// </summary>
        public float brake;
        /// <summary>
        /// Amount of clutch applied (0..100)
        /// </summary>
        public byte clutch;
        /// <summary>
        /// Gear selected
        /// -1 = R; 0 = N; 1-8
        /// </summary>
        public sbyte gear;
        /// <summary>
        /// Engine RPM
        /// </summary>
        public byte engineRPM;
        /// <summary>
        /// DRS active
        /// 0 = off; 1 = on
        /// </summary>
        public byte drs;
        /// <summary>
        /// Rev lights indictor (percentage)
        /// </summary>
        public byte revLightsPercent;
        /// <summary>
        /// Rev lights indicator (0-14)
        /// </summary>
        public short revLightsBitValue;
        /// <summary>
        /// Brakes temperature in celsius
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public short[] brakesTemperature;
        /// <summary>
        /// Tyres surface temperature in celsius
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] tyresSurfaceTemperature;
        /// <summary>
        /// Tyres inner temperature in celsius
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] tyresInnerTemperature;
        /// <summary>
        /// Engine temperature in celsius
        /// </summary>
        public short engineTemperature;
        /// <summary>
        /// Driving surface
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public SurfaceType[] surfaceType;
    }
}
