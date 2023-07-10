using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp;
using F1Sharp.Data;

namespace F1Sharp.ViewModels
{
    public partial class CarTelemetry : ObservableObject
    {
        /// <summary>
        /// Speed in kilometers per hour
        /// </summary>
        [ObservableProperty]
        private ushort _speed;

        /// <summary>
        /// Amount of throttle applied (0..1)
        /// </summary>
        [ObservableProperty]
        private float _throttle;

        /// <summary>
        /// <para>Amount of steering applied (-1..1)</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>-1</term>
        ///         <description>Full lock left</description>
        ///     </item>
        ///     <item>
        ///         <term>0</term>
        ///         <description>Neutral</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Full lock right</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private float _steer;

        /// <summary>
        /// Amount of brake applied (0..1)
        /// </summary>
        [ObservableProperty]
        private float _brake;

        /// <summary>
        /// Amount of clutch applied (0..100)
        /// </summary>
        [ObservableProperty]
        private byte _clutch;

        /// <summary>
        /// <para>Gear selected</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>-1</term>
        ///         <description>Reverse</description>
        ///     </item>
        ///     <item>
        ///         <term>0</term>
        ///         <description>Neutral</description>
        ///     </item>
        ///     <item>
        ///         <term>1-8</term>
        ///         <description>Gears</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private sbyte _gear;

        /// <summary>
        /// Engine RPM
        /// </summary>
        [ObservableProperty]
        private ushort _engineRPM;

        /// <summary>
        /// <para>DRS active</para>
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
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _drs;

        /// <summary>
        /// Rev lights indictor (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _revLightsPercent;

        /// <summary>
        /// Rev lights indicator (0-14)
        /// </summary>
        [ObservableProperty]
        private ushort _revLightsBitValue;

        /// <summary>
        /// Brakes temperature in celsius
        /// </summary>
        [ObservableProperty]
        private ushort[] _brakesTemperature;

        /// <summary>
        /// Tyres surface temperature in celsius
        /// </summary>
        [ObservableProperty]
        private byte[] _tyresSurfaceTemperature;

        /// <summary>
        /// Tyres inner temperature in celsius
        /// </summary>
        [ObservableProperty]
        private byte[] _tyresInnerTemperature;

        /// <summary>
        /// Engine temperature in celsius
        /// </summary>
        [ObservableProperty]
        private ushort _engineTemperature;

        /// <summary>
        /// Tyres pressure (PSI)
        /// </summary>
        [ObservableProperty]
        private float[] _tyresPressure;

        /// <summary>
        /// <para>Driving surface for each wheel</para>
        /// <para>See <see cref="F1Sharp.SurfaceType"/> for surface types.</para>
        /// <para>See <see cref="Wheel"/> for wheel index.</para>
        /// </summary>
        [ObservableProperty]
        private SurfaceType[] surfaceType;

        /// <summary>
        /// Updates the ViewModel with data coming from the corresponding UDP packet
        /// </summary>
        /// <param name="data">The data coming from UDP</param>
        public void Update(CarTelemetryData data)
        {
            Speed = data.speed;
            Throttle = data.throttle;
            Steer = data.steer;
            Brake = data.brake;
            Clutch = data.clutch;
            Gear = data.gear;
            EngineRPM = data.engineRPM;
            Drs = data.drs;
            RevLightsPercent = data.revLightsPercent;
            RevLightsBitValue = data.revLightsBitValue;
            BrakesTemperature = data.brakesTemperature;
            TyresSurfaceTemperature = data.tyresSurfaceTemperature;
            TyresInnerTemperature = data.tyresInnerTemperature;
            EngineTemperature = data.engineTemperature;
            TyresPressure = data.tyresPressure;
            SurfaceType = data.surfaceType;
        }
    }
}
