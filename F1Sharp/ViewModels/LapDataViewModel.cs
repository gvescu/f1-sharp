using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp.Data;
using System.Runtime.CompilerServices;

namespace F1Sharp.ViewModels
{
    public partial class LapDataViewModel : ObservableObject
    {
        [ObservableProperty]
        private uint _lastLapTimeInMS;

        [ObservableProperty]
        private uint _currentLapTimeInMS;

        [ObservableProperty]
        private ushort _sector1TimeInMS;

        [ObservableProperty]
        private byte _sector1TimeInMinutes;

        [ObservableProperty]
        private ushort _sector2TimeInMS;

        [ObservableProperty]
        private ushort _sector2TimeInMinutes;

        [ObservableProperty]
        private ushort _deltaToCarInFrontInMS;

        [ObservableProperty]
        private ushort _deltaToRaceLeaderInMS;

        [ObservableProperty]
        private float _lapDistance;

        [ObservableProperty]
        private float _totalDistance;

        [ObservableProperty]
        private float _safetyCarDelta;

        [ObservableProperty]
        private byte _carPosition;

        [ObservableProperty]
        private byte _currentLapNum;

        [ObservableProperty]
        private PitStatus _pitStatus;

        [ObservableProperty]
        private Sector _sector;

        [ObservableProperty]
        private byte _currentLapInvalid;

        [ObservableProperty]
        private byte _penalties;

        [ObservableProperty]
        private byte _totalWarnings;

        [ObservableProperty]
        private byte _cornerCuttingWarnings;

        [ObservableProperty]
        private byte _numUnservedDriveThroughPens;

        [ObservableProperty]
        private byte _numUnservedStopGoPens;

        [ObservableProperty]
        private byte _gridPosition;

        [ObservableProperty]
        private DriverStatus _driverStatus;

        [ObservableProperty]
        private ResultStatus _resultStatus;

        [ObservableProperty]
        private byte _pitLaneTimerActive;

        [ObservableProperty]
        private ushort _pitLaneTimeInLaneInMS;

        [ObservableProperty]
        private ushort _pitStopTimerInMS;

        [ObservableProperty]
        private byte _pitStopShouldServePen;

        public void Update(LapData data)
        {
            LastLapTimeInMS = data.lastLapTimeInMS;
            CurrentLapTimeInMS = data.currentLapTimeInMS;
            Sector1TimeInMS = data.sector1TimeInMS;
            Sector1TimeInMinutes = data.sector1TimeMinutes;
            Sector2TimeInMS = data.sector2TimeInMS;
            Sector2TimeInMinutes = data.sector2TimeMinutes;
            DeltaToCarInFrontInMS = data.deltaToCarInFrontInMS;
            DeltaToRaceLeaderInMS = data.deltaToRaceLeaderInMS;
            LapDistance = data.lapDistance;
            TotalDistance = data.totalDistance;
            SafetyCarDelta = data.safetyCarDelta;
            CarPosition = data.carPosition;
            CurrentLapNum = data.currentLapNum;
            PitStatus = data.pitStatus;
            Sector = data.sector;
            CurrentLapInvalid = data.currentLapInvalid;
            Penalties = data.penalties;
            TotalWarnings = data.totalWarnings;
            CornerCuttingWarnings = data.cornerCuttingWarnings;
            NumUnservedDriveThroughPens = data.numUnservedDriveThroughPens;
            NumUnservedStopGoPens = data.numUnservedStopGoPens;
            GridPosition = data.gridPosition;
            DriverStatus = data.driverStatus;
            ResultStatus = data.resultStatus;
            PitLaneTimerActive = data.pitLaneTimerActive;
            PitLaneTimeInLaneInMS = data.pitLaneTimeInLaneInMS;
            PitStopTimerInMS = data.pitStopTimerInMS;
            PitStopShouldServePen = data.pitStopShouldServePen;
        }
    }
}
