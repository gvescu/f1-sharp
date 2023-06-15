using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Data for the marshal zone
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MarshalZone
    {
        /// <summary>
        /// Fraction (0..1) of the way through the lap the marshall zone starts
        /// </summary>
        public float zoneStart;
        /// <summary>
        /// Flag currently displayed on the zone
        /// </summary>
        public ZoneFlag zoneFlag;
    }

    /// <summary>
    /// Data for the forecast sample
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct WeatherForecastSample
    {
        /// <summary>
        /// Type of the session
        /// </summary>
        public Session sessionType;
        /// <summary>
        /// Time in minutes the forecast is for
        /// </summary>
        public byte timeOffset;
        /// <summary>
        /// Weather type
        /// </summary>
        public Weather weather;
        /// <summary>
        /// Track temperature in degrees Celsius
        /// </summary>
        public sbyte trackTemperature;
        /// <summary>
        /// Track temperature change.
        /// 0 = up; 1 = down; 2 = no change
        /// </summary>
        public sbyte trackTemperatureChange;
        /// <summary>
        /// Air temperature in degrees Celsius
        /// </summary>
        public sbyte airTemperature;
        /// <summary>
        /// Air temperature change.
        /// 0 = up; 1 = down; 2 = no change
        /// </summary>
        public byte rainPercentage;
    }
}
