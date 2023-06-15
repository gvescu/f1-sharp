using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Tyre set data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct TyreSetData
    {
        /// <summary>
        /// Actual tyre compound used
        /// </summary>
        public TyreCompound actualTyreCompound;
        /// <summary>
        /// Visual tyre compound used
        /// </summary>
        public VisualTyreCompound visualTyreCompund;
        /// <summary>
        /// Tyre wear (percentage)
        /// </summary>
        public byte wear;
        /// <summary>
        /// Whether this set is currently available
        /// </summary>
        public byte available;
        /// <summary>
        /// Recommended session for tyre set
        /// </summary>
        public byte recommendedSession;
        /// <summary>
        /// Laps left in this tyre set
        /// </summary>
        public byte lifeSpan;
        /// <summary>
        /// Max number of laps recommended for this compound
        /// </summary>
        public byte usableLife;
        /// <summary>
        /// Lap delta time in milliseconds compared to fitted set
        /// </summary>
        public byte lapDeltaTime;
        /// <summary>
        /// Whether the set is fitted or not
        /// </summary>
        public byte fitted;
    }
}
