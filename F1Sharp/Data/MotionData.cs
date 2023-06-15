using System.Runtime.InteropServices;

namespace F1Sharp.Data
{
    /// <summary>
    /// Motion data for a car
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MotionData
    {
        /// <summary>
        /// World space X position (in meters)
        /// </summary>
        public float worldPositionX;
        /// <summary>
        /// World space Y position (in meters)
        /// </summary>
        public float worldPositionY;
        /// <summary>
        /// World space Z position (in meters)
        /// </summary>
        public float worldPositionZ;
        /// <summary>
        /// Velocity in world space X (in meters per second)
        /// </summary>
        public float worldVelocityX;
        /// <summary>
        /// Velocity in world space Y (in meters per second)
        /// </summary>
        public float worldVelocityY;
        /// <summary>
        /// Velocity in world space Z (in meters per second)
        /// </summary>
        public float worldVelocityZ;
        /// <summary>
        /// World space forward X direction (normalised)
        /// </summary>
        public short worldForwardDirX;
        /// <summary>
        /// World space forward Y direction (normalised)
        /// </summary>
        public short worldForwardDirY;
        /// <summary>
        /// World space forward Z direction (normalised)
        /// </summary>
        public short worldForwardDirZ;
        /// <summary>
        /// World space right X direction (normalised)
        /// </summary>
        public short worldRightDirX;
        /// <summary>
        /// World space right Y direction (normalised)
        /// </summary>
        public short worldRightDirY;
        /// <summary>
        /// World space right Z direction (normalised)
        /// </summary>
        public short worldRightDirZ;
        /// <summary>
        /// Lateral G-Force component
        /// </summary>
        public float gForceLateral;
        /// <summary>
        /// Longitudinal G-Force component
        /// </summary>
        public float gForceLongitudinal;
        /// <summary>
        /// Vertical G-Force component
        /// </summary>
        public float gForceVertical;
        /// <summary>
        /// Yaw angle (in radians)
        /// </summary>
        public float yaw;
        /// <summary>
        /// Pitch angle (in radians)
        /// </summary>
        public float pitch;
        /// <summary>
        /// Roll angle (in radians)
        /// </summary>
        public float roll;
    }
}
