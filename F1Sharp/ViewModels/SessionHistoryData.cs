using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp.Data;

namespace F1Sharp.ViewModels
{
    public partial class LapHistory : ObservableObject
    {
        [ObservableProperty]
        private uint _lapTimeInMS;

        [ObservableProperty]
        private ushort _sector1TimeInMS;

        [ObservableProperty]
        private byte _sector1TimeMinutes;

        [ObservableProperty]
        private ushort _sector2TimeInMS;

        [ObservableProperty]
        private byte _sector2TimeMinutes;

        [ObservableProperty]
        private ushort _sector3TimeInMS;

        [ObservableProperty]
        private byte _sector3TimeMinutes;

        [ObservableProperty]
        private byte _lapValidBitFlags;
        
        public void Update(LapHistoryData data)
        {
            LapTimeInMS = data.lapTimeInMS;
            Sector1TimeInMS = data.sector1TimeInMS;
            Sector1TimeMinutes = data.sector1TimeMinutes;
            Sector2TimeInMS = data.sector2TimeInMS;
            Sector2TimeMinutes = data.sector2TimeMinutes;
            Sector3TimeInMS = data.sector3TimeInMS;
            Sector3TimeMinutes = data.sector3TimeMinutes;
            LapValidBitFlags = data.lapValidBitFlags;
        }
    }

    public partial class TyreStintHistory : ObservableObject
    {
        [ObservableProperty]
        private byte _endLap;

        [ObservableProperty]
        private TyreCompound _tyreActualCompound;

        [ObservableProperty]
        private VisualTyreCompound _tyreVisualCompound;

        public void Update(TyreStintHistoryData data)
        {
            EndLap = data.endLap;
            TyreActualCompound = data.tyreActualCompound;
            TyreVisualCompound = data.tyreVisualCompound;
        }
    }
}
