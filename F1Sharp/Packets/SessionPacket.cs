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
        /// <para>Current weather type.</para>
        /// <para>See <see cref="F1Sharp.Weather"/> for weather conditions.</para>
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
        /// <para>Identifier for the track the session is taking place.</para>
        /// <para>See <see cref="F1Sharp.Track"/> for track IDs.</para>
        /// </summary>
        public Track trackId;
        /// <summary>
        /// <para>Type of the cars in the session.</para>
        /// <para>See <see cref="F1Sharp.Formula"/> for the types of cars.</para>
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
        /// <para>List of marshal zones.</para>
        /// <para>See <see cref="MarshalZone"/> for parameters of each zone.</para>
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
        public MarshalZone[] marshalZones;
        /// <summary>
        /// <para>Safety car status</para>
        /// <para>See <see cref="F1Sharp.SafetyCarStatus"/> for the status values.</para>
        /// </summary>
        public SafetyCarStatus safetyCarStatus;
        /// <summary>
        /// <para>Indicates if it's a network game</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>Offline</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Online</description>
        ///     </item>
        /// </list>
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
        /// <para>Accuracy of the forecast</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>Perfect</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Approximate</description>
        ///     </item>
        /// </list>
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
        /// <para>Current game mode.</para>
        /// <para>See <see cref="F1Sharp.GameMode"/> for available game modes.</para>
        /// </summary>
        public GameMode gameMode;
        /// <summary>
        /// <para>Current rule set.</para>
        /// <para>See <see cref="F1Sharp.RuleSet"/> for available rule sets.</para>
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
