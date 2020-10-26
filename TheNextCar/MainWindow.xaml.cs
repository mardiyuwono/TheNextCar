using System.Windows;
using TheNextCar.Controller;

namespace TheNextCar
{
    public partial class MainWindow : Window, OnPowerChanged, OnDoorChanged, OnCarEngineStateChanged
    {
        private Car nextCar;
        public MainWindow()
        {
            InitializeComponent();
            AccuBatteryController accuBatteryController = new AccuBatteryController(this);
            DoorController doorController = new DoorController(this);
            nextCar = new Car(doorController, accuBatteryController, this);
        }

        private void OnStratButtonClicked(object sender, RoutedEventArgs e)
        {
            this.nextCar.toggleStartEngine();
        }

        private void OnDoorOpenButtonClicked(object sender, RoutedEventArgs e)
        {
            this.nextCar.toggleTheDoorButton();
        }

        private void OnLockDoorButtonClicked(object sender, RoutedEventArgs e)
        {
            this.nextCar.toggleTheLockDoorButton();
        }
      
        private void OnAccuButtonClicked(object sender, RoutedEventArgs e)
        {
            this.nextCar.toggleThePowerButton();
        }

        public void onPowerChangedStatus(string value, string message)
        {
            AccuState.Content = message;
            AccuButton.Content = value;
        }

        public void onLockDoorStateChanged(string value, string message)
        {
            LockDoorState.Content = message;
            LockDoorButton.Content = value;
        }

        public void onDoorOpenStateChanged(string value, string message)
        {
            DoorOpenState.Content = message;
            DoorOpenButton.Content = value;
        }

        public void onCarEngineStateChanged(string value, string message)
        {
            StartState.Content = message;
            StartButton.Content = value;
        }
    }
}