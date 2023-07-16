using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace F1Sharp.ViewModels
{
    public partial class TimingRow : ObservableObject
    {
        [ObservableProperty]
        private int _rowIndex = 0;
        
        [ObservableProperty]
        private int _position = 0;

        [ObservableProperty]
        private byte _aiControlled = 0;

        [ObservableProperty]
        private byte _driverId = 0;

        [ObservableProperty]
        private Platform _platform = Platform.UNKNOWN;
        
        [ObservableProperty]
        private string _name = "";

        [ObservableProperty]
        private byte _raceNumber = 0;

        [ObservableProperty]
        private Nationality _nationality = Nationality.OTHER;

        [ObservableProperty]
        private Team _teamId = Team.F1WORLD;

        [ObservableProperty]
        private ushort _sector1 = 0;

        [ObservableProperty]
        private ushort _sector2 = 0;

        [ObservableProperty]
        private ushort _sector3 = 0;

        [ObservableProperty]
        private PitStatus _pitStatus = PitStatus.NONE;

        [ObservableProperty]
        private byte _numPitStops = 0;

        [ObservableProperty]
        private byte _ersDeployMode = 0;

        [ObservableProperty]
        private float _ersStoreEnergy = 0;

        [ObservableProperty]
        private uint _bestLapTimeInMS = 0;

        [ObservableProperty]
        private uint _lastLapTimeInMS = 0;

        [ObservableProperty]
        private ushort _deltaToCarInFrontInMS = 0;

        [ObservableProperty]
        private ushort _deltaToLeaderInMS = 0;

        [ObservableProperty]
        private byte _penalties = 0;

        [ObservableProperty]
        private byte _cornerCuttingWarnings = 0;

        [ObservableProperty]
        private DriverStatus _driverStatus = DriverStatus.ON_TRACK;

        [ObservableProperty]
        private ResultStatus resultStatus = ResultStatus.ACTIVE;

        [ObservableProperty]
        private byte _currentLapNum = 0;
    }
}
