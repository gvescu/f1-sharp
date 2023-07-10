using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace F1Sharp.ViewModels
{
    public partial class TimingRow : ObservableObject
    {
        [ObservableProperty]
        private int _rowIndex;
        
        [ObservableProperty]
        private int _position;

        [ObservableProperty]
        private byte _aiControlled;

        [ObservableProperty]
        private byte _driverId;

        [ObservableProperty]
        private byte _platform;
        
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private byte _raceNumber;

        [ObservableProperty]
        private byte _nationality;

        [ObservableProperty]
        private byte _teamId;

        [ObservableProperty]
        private ushort _sector1;

        [ObservableProperty]
        private ushort _sector2;

        [ObservableProperty]
        private ushort _sector3;

        [ObservableProperty]
        private PitStatus _pitStatus;

        [ObservableProperty]
        private byte _numPitStops;

        [ObservableProperty]
        private byte _ersDeployMode;

        [ObservableProperty]
        private byte _ersStoreEnergy;

        [ObservableProperty]
        private uint _bestLapTimeInMS;

        [ObservableProperty]
        private uint _lastLapTimeInMS;

        [ObservableProperty]
        private ushort _deltaToCarInFrontInMS;

        [ObservableProperty]
        private ushort _deltaToLeaderInMS;

        [ObservableProperty]
        private byte _penalties;

        [ObservableProperty]
        private byte _cornerCuttingWarnings;

        [ObservableProperty]
        private DriverStatus _driverStatus;

        [ObservableProperty]
        private ResultStatus resultStatus;

        [ObservableProperty]
        private byte _currentLapNum;
    }
}
