using CommunityToolkit.Mvvm.ComponentModel;

namespace F1Sharp.ViewModels
{
    public partial class TelemetryViewModel : ObservableObject
    {
        /// <summary>
        /// Car damage ViewModel
        /// </summary>
        [ObservableProperty]
        private CarDamageViewModel _carDamageViewModel;

        /// <summary>
        /// Car setup ViewModel
        /// </summary>
        [ObservableProperty]
        private CarSetupViewModel _carSetupViewModel;

        /// <summary>
        /// Car status ViewModel
        /// </summary>
        [ObservableProperty]
        private CarStatusViewModel _carStatusViewModel;

        /// <summary>
        /// Car telemetry ViewModel
        /// </summary>
        [ObservableProperty]
        private CarTelemetryViewModel _carTelemetryViewModel;

        /// <summary>
        /// Participant ViewModel
        /// </summary>
        [ObservableProperty]
        private ParticipantViewModel _participantViewModel;

        public TelemetryViewModel()
        {
            CarDamageViewModel = new CarDamageViewModel();
            CarSetupViewModel = new CarSetupViewModel();
            CarStatusViewModel = new CarStatusViewModel();
            CarTelemetryViewModel = new CarTelemetryViewModel();
            ParticipantViewModel = new ParticipantViewModel();
        }
    }
}
