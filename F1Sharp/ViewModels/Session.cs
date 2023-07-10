using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp;
using F1Sharp.Data;
using F1Sharp.Packets;

namespace F1Sharp.ViewModels
{
    public partial class Session : ObservableObject
    {
        /// <summary>
        /// Packet header
        /// </summary>
        [ObservableProperty]
        private PacketHeader _header;

        /// <summary>
        /// <para>Current weather type.</para>
        /// <para>See <see cref="F1Sharp.Weather"/> for weather conditions.</para>
        /// </summary>
        [ObservableProperty]
        private Weather _weather;

        /// <summary>
        /// Track temperature in degrees Celsius
        /// </summary>
        [ObservableProperty]
        private sbyte _trackTemperature;

        /// <summary>
        /// Air temperature in degrees Celsius
        /// </summary>
        [ObservableProperty]
        private sbyte _airTemperature;

        /// <summary>
        /// Total number of laps in this race
        /// </summary>
        [ObservableProperty]
        private byte _totalLaps;

        /// <summary>
        /// Track length in meters
        /// </summary>
        [ObservableProperty]
        private ushort _trackLength;

        /// <summary>
        /// Type of the session
        /// </summary>
        [ObservableProperty]
        private F1Sharp.Session _sessionType;

        /// <summary>
        /// <para>Identifier for the track the session is taking place.</para>
        /// <para>See <see cref="F1Sharp.Track"/> for track IDs.</para>
        /// </summary>
        [ObservableProperty]
        private Track _trackId;

        /// <summary>
        /// <para>Type of the cars in the session.</para>
        /// <para>See <see cref="F1Sharp.Formula"/> for the types of cars.</para>
        /// </summary>
        [ObservableProperty]
        private Formula _formula;

        /// <summary>
        /// Time left in session in seconds
        /// </summary>
        [ObservableProperty]
        private ushort _sessionTimeLeft;

        /// <summary>
        /// Session duration in seconds
        /// </summary>
        [ObservableProperty]
        private ushort _sessionDuration;

        /// <summary>
        /// Pit speed limit in kilometers per hour
        /// </summary>
        [ObservableProperty]
        private byte _pitSpeedLimit;

        /// <summary>
        /// Whether the game is paused (network game only)
        /// </summary>
        [ObservableProperty]
        private byte _gamePaused;

        /// <summary>
        /// Whether the player is spectating
        /// </summary>
        [ObservableProperty]
        private byte isSpectating;

        /// <summary>
        /// The index of the car being spectated
        /// </summary>
        [ObservableProperty]
        private byte spectatorCarIndex;

        /// <summary>
        /// SLI pro support.
        /// </summary>
        [ObservableProperty]
        private byte _sliProNativeSupport;

        /// <summary>
        /// Number of marshal zones to follow
        /// </summary>
        [ObservableProperty]
        private byte _numMarshalZones;

        /// <summary>
        /// <para>List of marshal zones.</para>
        /// <para>See <see cref="MarshalZone"/> for the attributes of each zone.</para>
        /// </summary>
        [ObservableProperty]
        private MarshalZone[] _marshalZones;

        /// <summary>
        /// <para>Safety car status</para>
        /// <para>See <see cref="F1Sharp.SafetyCarStatus"/> for the status values.</para>
        /// </summary>
        [ObservableProperty]
        private SafetyCarStatus _safetyCarStatus;

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
        [ObservableProperty]
        private byte _networkGame;

        /// <summary>
        /// Number of weather samples to follow
        /// </summary>
        [ObservableProperty]
        private byte _numWeatherForecastSamples;

        /// <summary>
        /// <para>List of weather samples</para>
        /// <para>See <see cref="WeatherForecastSample"/> for the attributes of each zone.</para>
        /// </summary>
        [ObservableProperty]
        private WeatherForecastSample[] _weatherForecastSamples;

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
        [ObservableProperty]
        private byte _forecastAccuracy;

        /// <summary>
        /// AI difficulty rating (0..110)
        /// </summary>
        [ObservableProperty]
        private byte _aiDifficulty;

        /// <summary>
        /// Identifier for season (persist accross saves)
        /// </summary>
        [ObservableProperty]
        private uint _seasonLinkIdentifier;

        /// <summary>
        /// Identifier for weekend (persist accross saves)
        /// </summary>
        [ObservableProperty]
        private uint _weekendLinkIdentifier;

        /// <summary>
        /// Identifier for session (persist accross saves)
        /// </summary>
        [ObservableProperty]
        private uint _sessionLinkIdentifier;

        /// <summary>
        /// Ideal lap to pit on for current strategy (player)
        /// </summary>
        [ObservableProperty]
        private byte _pitStopWindowIdealLap;

        /// <summary>
        /// Latest lap to pit on for current strategy (player)
        /// </summary>
        [ObservableProperty]
        private byte _pitStopWindowLatestLap;

        /// <summary>
        /// Predicted position to rejoin at (player)
        /// </summary>
        [ObservableProperty]
        private byte _pitStopRejoinPosition;

        /// <summary>
        /// <para>Current game mode.</para>
        /// <para>See <see cref="F1Sharp.GameMode"/> for available game modes.</para>
        /// </summary>
        [ObservableProperty]
        private GameMode _gameMode;

        /// <summary>
        /// <para>Current rule set.</para>
        /// <para>See <see cref="F1Sharp.RuleSet"/> for available rule sets.</para>
        /// </summary>
        [ObservableProperty]
        private RuleSet _ruleSet;

        /// <summary>
        /// Local time of day - minutes since midnight
        /// </summary>
        [ObservableProperty]
        private uint _timeOfDay;

        /// <summary>
        /// Length of the session
        /// </summary>
        [ObservableProperty]
        private SessionLength _sessionLength;

        /// <summary>
        /// Number of safety car periods
        /// </summary>
        [ObservableProperty]
        private byte _numSafetyCarPeriods;

        /// <summary>
        /// Number of virtual safety car periods
        /// </summary>
        [ObservableProperty]
        private byte _numVirtualSafetyCarPeriods;

        /// <summary>
        /// Number of red flag periods
        /// </summary>
        [ObservableProperty]
        private byte _numRedFlagPeriods;

        public void Update(SessionPacket packet)
        {
            Header = packet.header;
            Weather = packet.weather;
            TrackTemperature = packet.trackTemperature;
            AirTemperature = packet.airTemperature;
            TotalLaps = packet.totalLaps;
            TrackLength = packet.trackLength;
            SessionType = packet.sessionType;
            TrackId = packet.trackId;
            Formula = packet.formula;
            SessionTimeLeft = packet.sessionTimeLeft;
            SessionDuration = packet.sessionDuration;
            PitSpeedLimit = packet.pitSpeedLimit;
            GamePaused = packet.gamePaused;
            IsSpectating = packet.isSpectating;
            SpectatorCarIndex = packet.spectatorCarIndex;
            SliProNativeSupport = packet.sliProNativeSupport;
            NumMarshalZones = packet.numMarshalZones;
            MarshalZones = packet.marshalZones;
            SafetyCarStatus = packet.safetyCarStatus;
            NetworkGame = packet.networkGame;
            NumWeatherForecastSamples = packet.numWeatherForecastSamples;
            WeatherForecastSamples = packet.weatherForecastSamples;
            ForecastAccuracy = packet.forecastAccuracy;
            AiDifficulty = packet.aiDifficulty;
            SeasonLinkIdentifier = packet.seasonLinkIdentifier;
            WeekendLinkIdentifier = packet.weekendLinkIdentifier;
            SessionLinkIdentifier = packet.sessionLinkIdentifier;
            PitStopWindowIdealLap = packet.pitStopWindowIdealLap;
            PitStopWindowLatestLap = packet.pitStopWindowLatestLap;
            PitStopRejoinPosition = packet.pitStopRejoinPosition;
            GameMode = packet.gameMode;
            RuleSet = packet.ruleSet;
            TimeOfDay = packet.timeOfDay;
            SessionLength = packet.sessionlength;
            NumSafetyCarPeriods = packet.numSafetyCarPeriods;
            NumVirtualSafetyCarPeriods = packet.numVirtualSafetyCarPeriods;
            NumRedFlagPeriods = packet.numRedFlagPeriods;
        }
    }
}
