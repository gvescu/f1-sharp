using CommunityToolkit.Mvvm.ComponentModel;

namespace F1Sharp.ViewModels
{
    public partial class Player : ObservableObject
    {
        /// <summary>
        /// Player's car telemetry
        /// </summary>
        [ObservableProperty]
        private CarTelemetry _carTelemetry;

        /// <summary>
        /// Player's car status
        /// </summary>
        [ObservableProperty]
        private CarStatus _carStatus;

        /// <summary>
        /// Player's car setup
        /// </summary>
        [ObservableProperty]
        private CarSetup _carSetup;

        /// <summary>
        /// Player's car damage
        /// </summary>
        [ObservableProperty]
        private CarDamage _carDamage;

        /// <summary>
        /// Player's lap data
        /// </summary>
        [ObservableProperty]
        private LapData _lapData;

        public Player()
        {
            CarTelemetry = new();
            CarStatus = new();
            CarSetup = new();
            CarDamage = new();
            LapData = new();
        }
    }
}
