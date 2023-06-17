using F1Sharp.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace F1Sharp.ViewModels
{
    public partial class CarDamageViewModel : ObservableObject
    {
        /// <summary>
        /// Tyre wear (percentage)
        /// </summary>
        [ObservableProperty]
        private float[] _tyresWear;

        /// <summary>
        /// Tyre damage (percentage)
        /// </summary>
        [ObservableProperty]
        private byte[] _tyresDamage;

        /// <summary>
        /// Brakes damage (percentage)
        /// </summary>
        [ObservableProperty]
        private byte[] _brakesDamage;

        /// <summary>
        /// Front left wing damage (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _frontLeftWingDamage;

        /// <summary>
        /// Front right wing damage (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _frontRightWingDamage;

        /// <summary>
        /// Rear wing damage (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _rearWingDamage;

        /// <summary>
        /// Floor damage (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _floorDamage;

        /// <summary>
        /// Diffuser damage (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _diffuserDamage;

        /// <summary>
        /// Sidepod damage (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _sidepodDamage;

        /// <summary>
        /// <para>Indicator for DRS fault</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>OK</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Fault</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _drsFault;

        /// <summary>
        /// <para>Indicator for ERS fault</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>OK</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Fault</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _ersFault;

        /// <summary>
        /// Gear box damage (percent)
        /// </summary>
        [ObservableProperty]
        private byte _gearBoxDamage;

        /// <summary>
        /// Engine damage (percent)
        /// </summary>
        [ObservableProperty]
        private byte _engineDamage;

        /// <summary>
        /// Engine wear MGU-H (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _engineMGUHWear;

        /// <summary>
        /// Engine wear ES (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _engineESWear;

        /// <summary>
        /// Engine wear ICE (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _engineICEWear;

        /// <summary>
        /// Engine wear MGU-K (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _engineMGUKWear;

        /// <summary>
        /// Engine wear TC (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _engineTCWear;

        /// <summary>
        /// <para>Indicates if the engine is blown</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>OK</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Fault</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _engineBlown;

        /// <summary>
        /// <para>Indicates if the engine is seized</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>OK</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Fault</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _engineSeized;

        /// <summary>
        /// Updates the ViewModel with data coming from the corresponding UDP packet
        /// </summary>
        /// <param name="data">The data coming from UDP</param>
        public void Update(CarDamageData data)
        {
            TyresWear = data.tyresWear;
            TyresDamage = data.tyresDamage;
            BrakesDamage = data.brakesDamage;
            FrontLeftWingDamage = data.frontLeftWingDamage;
            FrontRightWingDamage = data.frontRightWingDamage;
            RearWingDamage = data.rearWingDamage;
            FloorDamage = data.floorDamage;
            DiffuserDamage = data.diffuserDamage;
            SidepodDamage = data.sidepodDamage;
            DrsFault = data.drsFault;
            ErsFault = data.ersFault;
            GearBoxDamage = data.gearBoxDamage;
            EngineDamage = data.engineDamage;
            EngineMGUHWear = data.engineMGUHWear;
            EngineESWear = data.engineESWear;
            EngineICEWear = data.engineICEWear;
            EngineMGUKWear = data.engineMGUKWear;
            EngineTCWear = data.engineTCWear;
            EngineBlown = data.engineBlown;
            EngineSeized = data.engineSeized;
        }
    }
}
