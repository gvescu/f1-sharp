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
        /// Team ID
        /// </summary>
        public byte teamId;
        /// <summary>
        /// Whether it's My Team (1) or otherwise (0)
        /// </summary>
        public byte myTeam;
        /// <summary>
        /// Race number of the car
        /// </summary>
        public byte raceNumber;
        /// <summary>
        /// Nationality of the driver
        /// </summary>
        public byte nationality;
        /// <summary>
        /// Name of the participant
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public char[] name;
        /// <summary>
        /// Player's UDP setting
        /// 0 = restricted; 1 = public
        /// </summary>
        public byte yourTelemetry;
        /// <summary>
        /// Player's "show online names" setting
        /// 0 = off; 1 = on
        /// </summary>
        public byte showOnlineNames;
        /// <summary>
        /// Platform of the player
        /// </summary>
        public Platform platform;
    }
}
