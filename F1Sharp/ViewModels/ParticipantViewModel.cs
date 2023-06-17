using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp.Data;

namespace F1Sharp.ViewModels
{
    public partial class ParticipantViewModel : ObservableObject
    {
        /// <summary>
        /// Whether the car is controlled by the AI (1) or the human (0)
        /// </summary>
        [ObservableProperty]
        private byte _aiControlled;

        /// <summary>
        /// Driver ID. 255 if network human.
        /// </summary>
        [ObservableProperty]
        private byte _driverId;

        /// <summary>
        /// Unique identifier for network players
        /// </summary>
        [ObservableProperty]
        private byte _networkId;

        /// <summary>
        /// Team ID
        /// </summary>
        [ObservableProperty]
        private byte _teamId;

        /// <summary>
        /// Whether it's My Team (1) or otherwise (0)
        /// </summary>
        [ObservableProperty]
        private byte _myTeam;

        /// <summary>
        /// Race number of the car
        /// </summary>
        [ObservableProperty]
        private byte _raceNumber;

        /// <summary>
        /// Nationality of the driver
        /// </summary>
        [ObservableProperty]
        private byte _nationality;

        /// <summary>
        /// Name of the participant
        /// </summary>
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// <para>Player's UDP setting</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>Restricted</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Public</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _yourTelemetry;

        /// <summary>
        /// <para>Player's "Show online names" setting</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>Off</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>On</description>
        ///     </item>
        ///     <item>
        ///         <term>1-8</term>
        ///         <description>Gears</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _showOnlineNames;

        /// <summary>
        /// <para>Platform of the player</para>
        /// <para>See <see cref="F1Sharp.Platform"/> for the available platforms.</para>
        /// </summary>
        [ObservableProperty]
        private Platform _platform;

        /// <summary>
        /// Updates the ViewModel with data coming from the corresponding UDP packet
        /// </summary>
        /// <param name="data">The data coming from UDP</param>
        public void Update(ParticipantData data)
        {
            AiControlled = data.aiControlled;
            DriverId = data.driverId;
            NetworkId = data.networkId;
            TeamId = data.teamId;
            MyTeam = data.myTeam;
            RaceNumber = data.raceNumber;
            Nationality = data.nationality;
            Name = new string(data.name);
            YourTelemetry = data.yourTelemetry;
            Platform = data.platform;
        }
    }
}
