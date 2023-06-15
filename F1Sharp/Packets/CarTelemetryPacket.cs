using F1Sharp.Data;
using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// This packet details telemetry for all the cars in the race.
    /// It details various values that would be recorded on the car such as speed, throttle application, DRS etc.
    /// Note that the rev light configurations are presented separately as well and will mimic real life driver preferences.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CarTelemetryPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// List of car telemetry data
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 22)]
        public CarTelemetryData[] carTelemetryData;
        /// <summary>
        /// Index of the MFD panel showing for the player
        /// </summary>
        public MfdPanelIndex mfdPanelIndex;
        /// <summary>
        /// Index of the MFD panel showing for the secondary player (splitscreen)
        /// </summary>
        public MfdPanelIndex mfdPanelIndexSecondaryPlayer;
        /// <summary>
        /// Suggested gear for the player
        /// </summary>
        public sbyte suggestedGear;
    }
}
