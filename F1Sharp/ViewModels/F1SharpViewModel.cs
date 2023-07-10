using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
        private ObservableCollection<CarTelemetry> _lobbyCarTelemetry;

        /// <summary>
        /// List of car damage ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<CarDamage> _lobbyCarDamage;

        /// <summary>
        /// List of car setup ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<CarSetup> _lobbyCarSetup;

        /// <summary>
        /// List of car status ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<CarStatus> _lobbyCarStatus;

        /// <summary>
        /// List of participant ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<Participants> _lobbyParticipants;

        /// <summary>
        /// List of lap data ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<LapData> _lobbyLapData;

        /// <summary>
        /// List of session history ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<SessionHistory> _lobbySessionHistory;

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
            NumActiveCars = 0;
            Player = new();
            Rival = new();
            Session = new();
            LobbyCarTelemetry = new();
            LobbyCarDamage = new();
            LobbyCarSetup = new();
            LobbyCarStatus = new();
            LobbyParticipants = new();
            LobbyLapData = new();
            LobbySessionHistory = new();
            TimingTable = new();
        }
    }
}
