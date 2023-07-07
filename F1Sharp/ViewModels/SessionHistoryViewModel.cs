using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp.Packets;
using System.Collections.Generic;

namespace F1Sharp.ViewModels
{
    public partial class SessionHistoryViewModel : ObservableObject
    {
        [ObservableProperty]
        private PacketHeader _header;

        [ObservableProperty]
        private byte _carIdx;

        [ObservableProperty]
        private byte _numLaps;

        [ObservableProperty]
        private byte _numTyreStints;

        [ObservableProperty]
        private byte _bestLapTimeLapNum;

        [ObservableProperty]
        private byte _bestSector1LapNum;

        [ObservableProperty]
        private byte _bestSector2LapNum;

        [ObservableProperty]
        private byte _bestSector3LapNum;

        [ObservableProperty]
        private List<LapHistoryViewModel> _lapHistory;

        [ObservableProperty]
        private List<TyreStintHistoryViewModel> _tyreHistory;

        public void Update(SessionHistoryPacket packet, List<LapHistoryViewModel> lapHistoryData, List<TyreStintHistoryViewModel> tyreStintHistoryData)
        {
            Header = packet.header;
            CarIdx = packet.carIdx;
            NumLaps = packet.numLaps;
            NumTyreStints = packet.numTyreStints;
            BestLapTimeLapNum = packet.bestLapTimeLapNum;
            BestSector1LapNum = packet.bestSector1Lapnum;
            BestSector2LapNum = packet.bestSector2Lapnum;
            BestSector3LapNum = packet.bestSector3Lapnum;
            LapHistory = lapHistoryData;
            TyreHistory = tyreStintHistoryData;
        }

        public SessionHistoryViewModel()
        {
            LapHistory = new();
            TyreHistory = new();
        }
    }
}
