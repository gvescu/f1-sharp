
using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Car damage data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CarDamageData
    {
        /// <summary>
        /// Tyre wear (percentage)
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] tyresWear;
        /// <summary>
        /// Tyre damage (percentage)
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] tyresDamage;
        /// <summary>
        /// Brakes damage (percentage)
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] brakesDamage;
        /// <summary>
        /// Front left wing damage (percentage)
        /// </summary>
        public byte frontLeftWingDamage;
        /// <summary>
        /// Front right wing damage (percentage)
        /// </summary>
        public byte frontRightWingDamage;
        /// <summary>
        /// Rear wing damage (percentage)
        /// </summary>
        public byte rearWingDamage;
        /// <summary>
        /// Floor damage (percentage)
        /// </summary>
        public byte floorDamage;
        /// <summary>
        /// Diffuser damage (percentage)
        /// </summary>
        public byte diffuserDamage;
        /// <summary>
        /// Sidepod damage (percentage)
        /// </summary>
        public byte sidepodDamage;
        /// <summary>
        /// Indicator for DRS fault
        /// 0 = OK; 1 = fault
        /// </summary>
        public byte drsFault;
        /// <summary>
        /// Indicator for ERS fault
        /// 0 = OK; 1 = fault
        /// </summary>
        public byte ersFault;
        /// <summary>
        /// Gear box damage (percent)
        /// </summary>
        public byte gearBoxDamage;
        /// <summary>
        /// Engine damage (percent)
        /// </summary>
        public byte engineDamage;
        /// <summary>
        /// Engine wear MGU-H (percentage)
        /// </summary>
        public byte engineMGUHWear;
        /// <summary>
        /// Engine wear ES (percentage)
        /// </summary>
        public byte engineESWear;
        /// <summary>
        /// Engine wear ICE (percentage)
        /// </summary>
        public byte engineICEWear;
        /// <summary>
        /// Engine wear MGU-K (percentage)
        /// </summary>
        public byte engineMGUKWear;
        /// <summary>
        /// Engine wear TC (percentage)
        /// </summary>
        public byte engineTcWear;
        /// <summary>
        /// Indicates if the engine is blown
        /// 0 = OK; 1 = fault
        /// </summary>
        public byte engineBlown;
        /// <summary>
        /// Indicates if the engine is seized
        /// 0 = OK; 1 = fault
        /// </summary>
        public byte engineSeized;
    }
}
