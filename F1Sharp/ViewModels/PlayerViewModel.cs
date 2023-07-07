using CommunityToolkit.Mvvm.ComponentModel;

namespace F1Sharp.ViewModels
{
    public partial class PlayerViewModel : ObservableObject
    {
        /// <summary>
        /// Player's car telemetry
        /// </summary>
        [ObservableProperty]
        private CarTelemetryViewModel _carTelemetry;

        /// <summary>
        /// Player's car status
        /// </summary>
        [ObservableProperty]
        private CarStatusViewModel _carStatus;

        /// <summary>
        /// Player's car setup
        /// </summary>
        [ObservableProperty]
        private CarSetupViewModel _carSetup;

        /// <summary>
        /// Player's car damage
        /// </summary>
        [ObservableProperty]
        private CarDamageViewModel _carDamage;

        /// <summary>
        /// Player's lap data
        /// </summary>
        [ObservableProperty]
        private LapDataViewModel _lapData;

        public PlayerViewModel()
        {
            CarTelemetry = new();
            CarStatus = new();
            CarSetup = new();
            CarDamage = new();
            LapData = new();
        }
    }
}
