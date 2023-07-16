using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace F1Sharp.ViewModels
{
    public partial class UDPTelemetry : ObservableObject
    {

        /// <summary>
        /// Client's port
        /// </summary>
        [ObservableProperty]
        private int _port;

        /// <summary>
        /// Number of active cars
        /// </summary>
        [ObservableProperty]
        private int _numActiveCars;

        /// <summary>
        /// Player's ViewModel
        /// </summary>
        [ObservableProperty]
        private Player _player;

        /// <summary>
        /// Rival's ViewModel
        /// </summary>
        [ObservableProperty]
        private Player _rival;

        /// <summary>
        /// Session's ViewModel
        /// </summary>
        [ObservableProperty]
        private Session _session;

        /// <summary>
        /// List of car telemetry ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private CarTelemetry[] _lobbyCarTelemetry;

        /// <summary>
        /// List of car damage ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private CarDamage[] _lobbyCarDamage;

        /// <summary>
        /// List of car setup ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private CarSetup[] _lobbyCarSetup;

        /// <summary>
        /// List of car status ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private CarStatus[] _lobbyCarStatus;

        /// <summary>
        /// List of participant ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private Participant[] _lobbyParticipants;

        /// <summary>
        /// List of lap data ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private LapData[] _lobbyLapData;

        /// <summary>
        /// List of session history ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private SessionHistory[] _lobbySessionHistory;

        /// <summary>
        /// Timing table
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<TimingRow> _timingTable;

        /// <summary>
        /// ViewModel constructor
        /// </summary>
        public UDPTelemetry()
        {
            Port = 20777;
            ResetViewModels();
        }

        public void ResetViewModels()
        {
            NumActiveCars = 0;
            Player = new();
            Rival = new();
            Session = new();
            LobbyCarTelemetry = new CarTelemetry[22];
            LobbyCarDamage = new CarDamage[22];
            LobbyCarSetup = new CarSetup[22];
            LobbyCarStatus = new CarStatus[22];
            LobbyParticipants = new Participant[22];
            LobbyLapData = new LapData[22];
            LobbySessionHistory = new SessionHistory[22];
            TimingTable = new();

            for (int i = 0; i < 22; i++)
            {
                LobbyCarTelemetry[i] = new();
                LobbyCarDamage[i] = new();
                LobbyCarSetup[i] = new();
                LobbyCarStatus[i] = new();
                LobbyParticipants[i] = new();
                LobbyLapData[i] = new();
                LobbySessionHistory[i] = new();
            }
        }

        public void UpdateTimingRowData(TimingRow newRow)
        {
            TimingRow existingRow = TimingTable.FirstOrDefault(row => row.RowIndex == newRow.RowIndex);

            if (existingRow != null)
            {
                int index = TimingTable.IndexOf(existingRow);
                TimingTable[index] = newRow;
            }
        }
    }
}
