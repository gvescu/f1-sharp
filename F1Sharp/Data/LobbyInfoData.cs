using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Data for player in lobby
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct LobbyInfoData
    {
        /// <summary>
        /// Whether the vehicle is controlled by the AI (1) or the human (0)
        /// </summary>
        public byte aiControlled;
        /// <summary>
        /// Team ID
        /// </summary>
        public byte teamId;
        /// <summary>
        /// Nationality
        /// </summary>
        public byte nationality;
        /// <summary>
        /// Platform of the player
        /// </summary>
        public Platform platform;
        /// <summary>
        /// Name of the player
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
        public char[] name;
        /// <summary>
        /// Number of the car
        /// </summary>
        public byte carNumber;
        /// <summary>
        /// Ready status
        /// 0 = not ready; 1 = ready; 2 = spectating
        /// </summary>
        public byte readyStatus;
    }
}
