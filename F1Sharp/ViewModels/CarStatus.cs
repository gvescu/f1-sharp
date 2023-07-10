using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp;
using F1Sharp.Data;

namespace F1Sharp.ViewModels
{
    public partial class CarStatus : ObservableObject
    {
        /// <summary>
        /// <para>Traction control level</para>
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
        ///         <description>Medium</description>
        ///     </item>
        ///     <item>
        ///         <term>2</term>
        ///         <description>Full</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _tractionControl;

        /// <summary>
        /// <para>ABS status</para>
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
        private byte _antiLockBrakes;

        /// <summary>
        /// <para>Current fuel mix</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>Lean</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Standard</description>
        ///     </item>
        ///     <item>
        ///         <term>2</term>
        ///         <description>Rich</description>
        ///     </item>
        ///     <item>
        ///         <term>3</term>
        ///         <description>Max</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _fuelMix;

        /// <summary>
        /// Front brake bias (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _frontBrakeBias;

        /// <summary>
        /// <para>Pit limiter status</para>
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
        private byte _pitLimiterStatus;

        /// <summary>
        /// Current fuel mass
        /// </summary>
        [ObservableProperty]
        private float _fuelInTank;

        /// <summary>
        /// Fuel capacity
        /// </summary>
        [ObservableProperty]
        private float _fuelCapacity;

        /// <summary>
        /// Fuel remaining in terms of laps (value on MFD)
        /// </summary>
        [ObservableProperty]
        private float _fuelRemainingLaps;

        /// <summary>
        /// Car's max RPM, point of rev limiter
        /// </summary>
        [ObservableProperty]
        private ushort _maxRPM;

        /// <summary>
        /// Car's idle RPM
        /// </summary>
        [ObservableProperty]
        private ushort _idleRPM;

        /// <summary>
        /// Maximum number of gears
        /// </summary>
        [ObservableProperty]
        private byte _maxGears;

        /// <summary>
        /// <para>Whether the DRS is allowed</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>Not allowed</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Allowed</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _drsAllowed;

        /// <summary>
        /// <para>Distance where DRS will be available</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>Not available</description>
        ///     </item>
        ///     <item>
        ///         <term>Greater than 0</term>
        ///         <description>Distance in meters</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private ushort _drsActivationDistance;

        /// <summary>
        /// Tyre compound
        /// </summary>
        [ObservableProperty]
        private TyreCompound _actualTyreCompound;

        /// <summary>
        /// Visual tyre compound
        /// </summary>
        [ObservableProperty]
        private VisualTyreCompound _visualTyreCompound;

        /// <summary>
        /// Age in laps of current set of tyres
        /// </summary>
        [ObservableProperty]
        private byte _tyresAgeLaps;

        /// <summary>
        /// Flags shown to the car
        /// </summary>
        [ObservableProperty]
        private ZoneFlag _vehicleFiaFlags;

        /// <summary>
        /// Engine power output of ICE in watts
        /// </summary>
        [ObservableProperty]
        private float _enginePowerICE;

        /// <summary>
        /// Engine power output of MGU-K in watts
        /// </summary>
        [ObservableProperty]
        private float _enginePowerMGUK;

        /// <summary>
        /// ERS energy store in joules
        /// </summary>
        [ObservableProperty]
        private float _ersStoreEnergy;

        /// <summary>
        /// <para>ERS deployment mode</para>
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///     </listheader>
        ///     <item>
        ///         <term>0</term>
        ///         <description>None</description>
        ///     </item>
        ///     <item>
        ///         <term>1</term>
        ///         <description>Medium</description>
        ///     </item>
        ///     <item>
        ///         <term>2</term>
        ///         <description>Hotlap</description>
        ///     </item>
        ///     <item>
        ///         <term>3</term>
        ///         <description>Overtake</description>
        ///     </item>
        /// </list>
        /// </summary>
        [ObservableProperty]
        private byte _ersDeployMode;

        /// <summary>
        /// Energy harvested this lap by the MGU-K
        /// </summary>
        [ObservableProperty]
        private float _ersHarvestedThisLapMGUK;

        /// <summary>
        /// Energy harvested this lap by the MGU-H
        /// </summary>
        [ObservableProperty]
        private float _ersHarvestedThisLapMGUH;

        /// <summary>
        /// ERS energy deployed this lap
        /// </summary>
        [ObservableProperty]
        private float _ersDeployedThisLap;

        /// <summary>
        /// Whether the car is paused in a network game
        /// </summary>
        [ObservableProperty]
        private byte _networkPaused;

        /// <summary>
        /// Updates the ViewModel with data coming from the corresponding UDP packet
        /// </summary>
        /// <param name="data">The data coming from UDP</param>
        public void Update(CarStatusData data)
        {
            TractionControl = data.tractionControl;
            AntiLockBrakes = data.antiLockBrakes;
            FuelMix = data.fuelMix;
            FrontBrakeBias = data.frontBrakeBias;
            PitLimiterStatus = data.pitLimiterStatus;
            FuelInTank = data.fuelInTank;
            FuelCapacity = data.fuelCapacity;
            MaxRPM = data.maxRPM;
            IdleRPM = data.idleRPM;
            MaxGears = data.maxGears;
            DrsAllowed = data.drsAllowed;
            DrsActivationDistance = data.drsActivationDistance;
            ActualTyreCompound = data.actualTyreCompound;
            VisualTyreCompound = data.visualTyreCompound;
            TyresAgeLaps = data.tyresAgeLaps;
            VehicleFiaFlags = data.vehicleFiaFlags;
            EnginePowerICE = data.enginePowerICE;
            EnginePowerMGUK = data.enginePowerMGUK;
            ErsStoreEnergy = data.ersStoreEnergy;
            ErsDeployMode = data.ersDeployMode;
            ErsHarvestedThisLapMGUK = data.ersHarvestedThisLapMGUK;
            ErsHarvestedThisLapMGUH = data.ersHarvestedThisLapMGUH;
            ErsDeployedThisLap = data.ersDeployedThisLap;
            NetworkPaused = data.networkPaused;
        }
    }
}
