using System.Runtime.InteropServices;

namespace F1Sharp.Packets
{
    /// <summary>
    /// <para>The motion packet gives extended data for the car being driven with the goal of being able to drive a motion platform setup.</para>
    /// <para>All wheel arrays have the following order: <c>[RL, RR, FL, FR]</c></para>
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MotionExPacket
    {
        /// <summary>
        /// Packet header
        /// </summary>
        public PacketHeader header;
        /// <summary>
        /// Suspension position for each wheel
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionPosition;
        /// <summary>
        /// Suspension velocity for each wheel
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionVelocity;
        /// <summary>
        /// Suspension acceleration for each wheel
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] suspensionAcceleration;
        /// <summary>
        /// Speed of each wheel
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelSpeed;
        /// <summary>
        /// Slip ratio for each wheel
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelSlipRatio;
        /// <summary>
        /// Slip angles for each wheel
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelSlipAngle;
        /// <summary>
        /// Lateral forces for each wheel
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelLatForce;
        /// <summary>
        /// Longitudinal forces for each wheel
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelLongForce;
        /// <summary>
        /// Height of center of gravity above ground
        /// </summary>
        public float heightOfCOGAboveGround;
        /// <summary>
        /// Velocity in local space X in meters per second
        /// </summary>
        public float localVelocityX;
        /// <summary>
        /// Velocity in local space Y in meters per second
        /// </summary>
        public float localVelocityY;
        /// <summary>
        /// Velocity in local space Z in meters per second
        /// </summary>
        public float localVelocityZ;
        /// <summary>
        /// Angular velocity X component in radians per second
        /// </summary>
        public float angularVelocityX;
        /// <summary>
        /// Angular velocity Y component in radians per second
        /// </summary>
        public float angularVelocityY;
        /// <summary>
        /// Angular velocity Z component in radians per second
        /// </summary>
        public float angularVelocityZ;
        /// <summary>
        /// Angular acceleration X component in radians per second squared
        /// </summary>
        public float angularAccelerationX;
        /// <summary>
        /// Angular acceleration Y component in radians per second squared
        /// </summary>
        public float angularAccelerationY;
        /// <summary>
        /// Angular acceleration Z component in radians per second squared
        /// </summary>
        public float angularAccelerationZ;
        /// <summary>
        /// Current front wheels angle in radians
        /// </summary>
        public float frontWheelsAngle;
        /// <summary>
        /// Vertical forces for each wheel
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] wheelVertForce;
    }
}
