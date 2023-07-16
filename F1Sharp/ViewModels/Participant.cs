using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp.Data;
using System;
using System.Text;

namespace F1Sharp.ViewModels
{
    public partial class Participant : ObservableObject
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
        /// <para>Team ID</para>
        /// <para>See <see cref="Team"/> for the list of teams.</para>
        /// </summary>
        [ObservableProperty]
        private Team _teamId;

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
        /// <para>Nationality of the driver </para>
        /// <para>See <see cref="F1Sharp.Nationality"/> for the list of nationalities.</para>
        /// </summary>
        [ObservableProperty]
        private Nationality _nationality;

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
            byte[] nameBytes = Encoding.UTF8.GetBytes(data.name);
            Name = Encoding.UTF8.GetString(nameBytes);
            YourTelemetry = data.yourTelemetry;
            Platform = data.platform;
        }
    }
}
