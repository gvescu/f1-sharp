using CommunityToolkit.Mvvm.ComponentModel;
using F1Sharp.Data;

namespace F1Sharp.ViewModels
{
    public partial class CarSetup : ObservableObject
    {
        /// <summary>
        /// Front wing aero
        /// </summary>
        [ObservableProperty]
        private byte _frontWing;

        /// <summary>
        /// Rear wing aero
        /// </summary>
        [ObservableProperty]
        private byte _rearWing;

        /// <summary>
        /// Differential adjustment on throttle (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _onThrottle;

        /// <summary>
        /// Differential adjustment off throttle (percentage)
        /// </summary>
        [ObservableProperty]
        private byte _offThrottle;

        /// <summary>
        /// Front camber angle
        /// </summary>
        [ObservableProperty]
        private float _frontCamber;

        /// <summary>
        /// Rear camber angle
        /// </summary>
        [ObservableProperty]
        private float _rearCamber;

        /// <summary>
        /// Front toe angle
        /// </summary>
        [ObservableProperty]
        private float _frontToe;

        /// <summary>
        /// Rear toe angle
        /// </summary>
        [ObservableProperty]
        private float _rearToe;

        /// <summary>
        /// Front suspension
        /// </summary>
        [ObservableProperty]
        private byte _frontSuspension;

        /// <summary>
        /// Rear suspension
        /// </summary>
        [ObservableProperty]
        private byte _rearSuspension;

        /// <summary>
        /// Front anti-roll bar
        /// </summary>
        [ObservableProperty]
        private byte _frontAntiRollBar;

        /// <summary>
        /// Rear anti-roll bar
        /// </summary>
        [ObservableProperty]
        private byte _rearAntiRollBar;

        /// <summary>
        /// Front ride height
        /// </summary>
        [ObservableProperty]
        private byte _frontSuspensionHeight;

        /// <summary>
        /// Rear ride height
        /// </summary>
        [ObservableProperty]
        private byte _rearSuspensionHeight;

        /// <summary>
        /// Brake pressure (percent)
        /// </summary>
        [ObservableProperty]
        private byte _brakePressure;

        /// <summary>
        /// Brake bias (percent)
        /// </summary>
        [ObservableProperty]
        private byte _brakeBias;

        /// <summary>
        /// Rear left tyre pressure (PSI)
        /// </summary>
        [ObservableProperty]
        private float _rearLeftTyrePressure;

        /// <summary>
        /// Rear right tyre pressure (PSI)
        /// </summary>
        [ObservableProperty]
        private float _rearRightTyrePressure;

        /// <summary>
        /// Front left tyre pressure (PSI)
        /// </summary>
        [ObservableProperty]
        private float _frontLeftTyrePressure;

        /// <summary>
        /// Front right tyre pressure (PSI)
        /// </summary>
        [ObservableProperty]
        private float _frontRightTyrePressure;

        /// <summary>
        /// Ballast
        /// </summary>
        [ObservableProperty]
        private byte _ballast;

        /// <summary>
        /// Fuel load
        /// </summary>
        [ObservableProperty]
        private byte _fuelLoad;

        /// <summary>
        /// Updates the ViewModel with data coming from the corresponding UDP packet
        /// </summary>
        /// <param name="data">The data coming from UDP</param>
        public void Update(CarSetupData data)
        {
            FrontWing = data.frontWing;
            RearWing = data.rearWing;
            OnThrottle = data.onThrottle;
            OffThrottle = data.offThrottle;
            FrontCamber = data.frontCamber;
            RearCamber = data.rearCamber;
            FrontToe = data.frontToe;
            RearToe = data.rearToe;
            FrontSuspension = data.frontSuspension;
            RearSuspension = data.rearSuspension;
            FrontAntiRollBar = data.frontAntiRollBar;
            RearAntiRollBar = data.rearAntiRollBar;
            FrontSuspensionHeight = data.frontSuspensionHeight;
            RearSuspensionHeight = data.rearSuspensionHeight;
            BrakePressure = data.brakePressure;
            BrakeBias = data.brakeBias;
            RearLeftTyrePressure = data.rearLeftTyrePressure;
            RearRightTyrePressure = data.rearRightTyrePressure;
            FrontLeftTyrePressure = data.frontLeftTyrePressure;
            FrontRightTyrePressure = data.frontRightTyrePressure;
            Ballast = data.ballast;
            FuelLoad = data.fuelLoad;
        }
    }
}
