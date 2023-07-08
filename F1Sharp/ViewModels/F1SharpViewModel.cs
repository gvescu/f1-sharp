using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace F1Sharp.ViewModels
{
    public partial class TelemetryViewModel : ObservableObject
    {

        /// <summary>
        /// Client's port
        /// </summary>
        [ObservableProperty]
        private int _port;

        /// <summary>
        /// Player's ViewModel
        /// </summary>
        [ObservableProperty]
        private PlayerViewModel _playerViewModel;

        /// <summary>
        /// Rival's ViewModel
        /// </summary>
        [ObservableProperty]
        private PlayerViewModel _rivalViewModel;

        /// <summary>
        /// Session's ViewModel
        /// </summary>
        [ObservableProperty]
        private SessionViewModel _sessionViewModel;

        /// <summary>
        /// List of car telemetry ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private List<CarTelemetryViewModel> _lobbyCarTelemetryViewModels;

        /// <summary>
        /// List of car damage ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private List<CarDamageViewModel> _lobbyCarDamageViewModels;

        /// <summary>
        /// List of car setup ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private List<CarSetupViewModel> _lobbyCarSetupViewModels;

        /// <summary>
        /// List of car status ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private List<CarStatusViewModel> _lobbyCarStatusViewModels;

        /// <summary>
        /// List of participant ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private List<ParticipantViewModel> _lobbyParticipantViewModels;

        /// <summary>
        /// List of lap data ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private List<LapDataViewModel> _lobbyLapDataViewModels;

        /// <summary>
        /// List of session history ViewModels from lobby players
        /// </summary>
        [ObservableProperty]
        private List<SessionHistoryViewModel> _lobbySessionHistoryViewModels;

        /// <summary>
        /// ViewModel constructor
        /// </summary>
        public TelemetryViewModel()
        {
            Port = 20777;
            PlayerViewModel = new();
            RivalViewModel = new();
            SessionViewModel = new();
            LobbyCarTelemetryViewModels = new();
            LobbyCarDamageViewModels = new();
            LobbyCarSetupViewModels = new();
            LobbyCarStatusViewModels = new();
            LobbyParticipantViewModels = new();
            LobbyLapDataViewModels = new();
            LobbySessionHistoryViewModels = new();

            for (int i = 0; i < 22; i++)
            {
                SessionHistoryViewModel sessionHistoryViewModel = new();
                LobbySessionHistoryViewModels.Add(sessionHistoryViewModel);
            }
        }
    }
}
