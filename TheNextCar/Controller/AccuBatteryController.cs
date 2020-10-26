using TheNextCar.Model;

namespace TheNextCar.Controller
{
    class AccuBatteryController
    {
        private AccuBattery accuBattery;
        private OnPowerChanged callbakOnPowerChanged;

        public AccuBatteryController(OnPowerChanged callbakOnPowerChanged)
        {
            this.callbakOnPowerChanged = callbakOnPowerChanged;
            this.accuBattery = new AccuBattery(12); 
        }

        public void turnOn()
        {
            this.accuBattery.turnOn();
            this.callbakOnPowerChanged.onPowerChangedStatus("ON", "Power is ON");
        }
        public void turnOff()
        {
            this.accuBattery.turnOff();
            this.callbakOnPowerChanged.onPowerChangedStatus("OFF", "Power is OFF");
        }

        public bool accuBatteryIsOn()
        {
            return this.accuBattery.isOn();
        }
    }

    interface OnPowerChanged
    {
        void onPowerChangedStatus(string value, string message);
    }
}