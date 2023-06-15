using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// The session packet includes details about the current session in progress
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SessionPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Current weather type
        /// </summary>
        public Weather weather;
        /// <summary>
        /// Track temperature in degrees Celsius
        /// </summary>
        public sbyte trackTemperature;
        /// <summary>
        /// Air temperature in degrees Celsius
        /// </summary>
        public sbyte airTemperature;
        /// <summary>
        /// Total number of laps in this race
        /// </summary>
        public byte totalLaps;
        /// <summary>
        /// Track length in meters
        /// </summary>
        public ushort trackLength;
        /// <summary>
        /// Type of the session
        /// </summary>
        public Session sessionType;
        /// <summary>
        /// Identifier for the track the session is taking place
        /// </summary>
        public Track trackId;
        /// <summary>
        /// Type of the cars in the session
        /// </summary>
        public Formula formula;
        /// <summary>
        /// Time left in session in seconds
        /// </summary>
        public ushort sessionTimeLeft;
        /// <summary>
        /// Session duration in seconds
        /// </summary>
        public ushort sessionDuration;
        /// <summary>
        /// Pit speed limit in kilometers per hour
        /// </summary>
        public byte pitSpeedLimit;
        /// <summary>
        /// Whether the game is paused (network game only)
        /// </summary>
        public byte gamePaused;
        /// <summary>
        /// Whether the player is spectating
        /// </summary>
        public byte isSpectating;
        /// <summary>
        /// The index of the car being spectated
        /// </summary>
        public byte spectatorCarIndex;
        /// <summary>
        /// SLI pro support.
        /// 0 = inactive; 1 = active
        /// </summary>
        public byte sliProNativeSupport;
        /// <summary>
        /// Number of marshal zones to follow
        /// </summary>
        public byte numMarshalZones;
        /// <summary>
        /// List of marshal zones
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
        public MarshalZone[] marshalZones;
        /// <summary>
        /// Safety car status
        /// </summary>
        public SafetyCarStatus safetyCarStatus;
        /// <summary>
        /// Indicates if it's a network game.
        /// 0 = offline; 1 = online
        /// </summary>
        public byte networkGame;
        /// <summary>
        /// Number of weather samples to follow
        /// </summary>
        public byte numWeatherForecastSamples;
        /// <summary>
        /// List of weather samples
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
        public WeatherForecastSample[] weatherForecastSamples;
        /// <summary>
        /// Accuracy of the forecast
        /// 0 = perfect; 1 = approximate
        /// </summary>
        public byte forecastAccuracy;
        /// <summary>
        /// AI difficulty rating (0..110)
        /// </summary>
        public byte aiDifficulty;
        /// <summary>
        /// Identifier for season (persist accross saves)
        /// </summary>
        public uint seasonLinkIdentifier;
        /// <summary>
        /// Identifier for weekend (persist accross saves)
        /// </summary>
        public uint weekendLinkIdentifier;
        /// <summary>
        /// Identifier for session (persist accross saves)
        /// </summary>
        public uint sessionLinkIdentifier;
        /// <summary>
        /// Ideal lap to pit on for current strategy (player)
        /// </summary>
        public byte pitStopWindowIdealLap;
        /// <summary>
        /// Latest lap to pit on for current strategy (player)
        /// </summary>
        public byte pitStopWindowLatestLap;
        /// <summary>
        /// Predicted position to rejoin at (player)
        /// </summary>
        public byte pitStopRejoinPosition;
        public byte steeringAssist;
        public byte brakingAssist;
        public byte gearboxAssist;
        public byte pitAssist;
        public byte pitReleaseAssist;
        public byte ersAssist;
        public byte drsAssist;
        public byte dynamicRacingLine;
        public byte dynamicRacingLineType;
        /// <summary>
        /// Current game mode
        /// </summary>
        public GameMode gameMode;
        /// <summary>
        /// Current rule set
        /// </summary>
        public RuleSet ruleSet;
        /// <summary>
        /// Local time of day - minutes since midnight
        /// </summary>
        public uint timeOfDay;
        /// <summary>
        /// Length of the session
        /// </summary>
        public SessionLength sessionlength;
        /// <summary>
        /// Speed unit selected by the player (splitscreen)
        /// </summary>
        public SpeedUnit speedUnitsLeadPlayer;
        /// <summary>
        /// Temperature unit selected by the player (splitscreen)
        /// </summary>
        public TemperatureUnit temperatureUnitsLeadPlayer;
        /// <summary>
        /// Speed unit selected by the secondary player (splitscreen)
        /// </summary>
        public SpeedUnit speedUnitsSecondaryPlayer;
        /// <summary>
        /// Temperature unit selected by the secondary player (splitscreen)
        /// </summary>
        public TemperatureUnit temperatureUnitsSecondaryPlayer;
        /// <summary>
        /// Number of safety car periods
        /// </summary>
        public byte numSafetyCarPeriods;
        /// <summary>
        /// Number of virtual safety car periods
        /// </summary>
        public byte numVirtualSafetyCarPeriods;
        /// <summary>
        /// Number of red flag periods
        /// </summary>
        public byte numRedFlagPeriods;
    }
}
