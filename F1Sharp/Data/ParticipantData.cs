using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Data for each participant
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ParticipantData
    {
        /// <summary>
        /// Whether the car is controlled by the AI (1) or the human (0)
        /// </summary>
        public byte aiControlled;
        /// <summary>
        /// Driver ID. 255 if network human.
        /// </summary>
        public byte driverId;
        /// <summary>
        /// Unique identifier for network players
        /// </summary>
        public byte networkId;
        /// <summary>
        /// <para>Team ID</para>
        /// <para>See <see cref="Team"/> for the list of teams.</para>
        /// </summary>
        public Team teamId;
        /// <summary>
        /// Whether it's My Team (1) or otherwise (0)
        /// </summary>
        public byte myTeam;
        /// <summary>
        /// Race number of the car
        /// </summary>
        public byte raceNumber;
        /// <summary>
        /// <para>Nationality of the driver </para>
        /// <para>See <see cref="Nationality"/> for the list of nationalities.</para>
        /// </summary>
        public Nationality nationality;
        /// <summary>
        /// Name of the participant
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public char[] name;
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
        public byte yourTelemetry;
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
        public byte showOnlineNames;
        /// <summary>
        /// <para>Platform of the player</para>
        /// <para>See <see cref="Platform"/> for the available platforms.</para>
        /// </summary>
        public Platform platform;
    }
}
