using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp.Packets;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace F1Sharp.ViewModels
{
    public partial class SessionHistory : ObservableObject
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
        private ObservableCollection<LapHistory> _lapHistoryData;

        [ObservableProperty]
        private ObservableCollection<TyreStintHistory> _tyreHistoryData;

        public void Update(SessionHistoryPacket packet, ObservableCollection<LapHistory> lapHistoryData, ObservableCollection<TyreStintHistory> tyreStintHistoryData)
        {
            Header = packet.header;
            CarIdx = packet.carIdx;
            NumLaps = packet.numLaps;
            NumTyreStints = packet.numTyreStints;
            BestLapTimeLapNum = packet.bestLapTimeLapNum;
            BestSector1LapNum = packet.bestSector1Lapnum;
            BestSector2LapNum = packet.bestSector2Lapnum;
            BestSector3LapNum = packet.bestSector3Lapnum;
            LapHistoryData = lapHistoryData;
            TyreHistoryData = tyreStintHistoryData;
        }

        public SessionHistory()
        {
            LapHistoryData = new();
            TyreHistoryData = new();
        }
    }
}
