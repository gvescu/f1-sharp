using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Car setup data
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct CarSetupData
    {
        /// <summary>
        /// Front wing aero
        /// </summary>
        public byte frontWing;
        /// <summary>
        /// Rear wing aero
        /// </summary>
        public byte rearWing;
        /// <summary>
        /// Differential adjustment on throttle (percentage)
        /// </summary>
        public byte onThrottle;
        /// <summary>
        /// Differential adjustment off throttle (percentage)
        /// </summary>
        public byte offThrottle;
        /// <summary>
        /// Front camber angle
        /// </summary>
        public float frontCamber;
        /// <summary>
        /// Rear camber angle
        /// </summary>
        public float rearCamber;
        /// <summary>
        /// Front toe angle
        /// </summary>
        public float frontToe;
        /// <summary>
        /// Rear toe angle
        /// </summary>
        public float rearToe;
        /// <summary>
        /// Front suspension
        /// </summary>
        public byte frontSuspension;
        /// <summary>
        /// Rear suspension
        /// </summary>
        public byte rearSuspension;
        /// <summary>
        /// Front anti-roll bar
        /// </summary>
        public byte frontAntiRollBar;
        /// <summary>
        /// Rear anti-roll bar
        /// </summary>
        public byte rearAntiRollBar;
        /// <summary>
        /// Front ride height
        /// </summary>
        public byte frontSuspensionHeight;
        /// <summary>
        /// Rear ride height
        /// </summary>
        public byte rearSuspensionHeight;
        /// <summary>
        /// Brake pressure (percent)
        /// </summary>
        public byte brakePressure;
        /// <summary>
        /// Brake bias (percent)
        /// </summary>
        public byte brakeBias;
        /// <summary>
        /// Rear left tyre pressure (PSI)
        /// </summary>
        public float rearLeftTyrePressure;
        /// <summary>
        /// Rear Right tyre pressure (PSI)
        /// </summary>
        public float rearRightTyrePressure;
        /// <summary>
        /// Frontleft tyre pressure (PSI)
        /// </summary>
        public float frontLeftTyrePressure;
        /// <summary>
        /// Front right tyre pressure (PSI)
        /// </summary>
        public float frontRightTyrePressure;
        /// <summary>
        /// Ballast
        /// </summary>
        public byte ballast;
        /// <summary>
        /// Fuel load
        /// </summary>
        public byte fuelLoad;
    }
}
