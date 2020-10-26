namespace TheNextCar.Controller
{
    class Car
    {
        private DoorController doorController;
        private AccuBatteryController accuBatteryController;
        private OnCarEngineStateChanged callback;

        public Car(DoorController doorController, AccuBatteryController accuBatteryController, OnCarEngineStateChanged callback)
        {
            this.doorController = doorController;
            this.accuBatteryController = accuBatteryController;
            this.callback = callback;
        }

        public void turnOnPower()
        {
            this.accuBatteryController.turnOn();
        }

        public void turnOffPower()
        {
            this.accuBatteryController.turnOff();
        }

        public bool powerIsReady()
        {
            return this.accuBatteryController.accuBatteryIsOn();
        }

        public void closeTheDoor()
        {
            this.doorController.close();
        }

        public void openTheDoor()
        {
            this.doorController.open();
        }

        public void lockTheDoor()
        {
            this.doorController.activateLock();
        }

        public void unlockTheDoor()
        {
            this.doorController.unlock();
        }

        private bool doorIsClosed()
        {
            return this.doorController.isClose();
        }

        private bool doorIsLocked()
        {
            return this.doorController.isLocked();
        }

        public void toggleStartEngine()
        {
            if (!doorIsClosed())
            {
                this.callback.onCarEngineStateChanged("STOPPED", "Door is Open");
                return;
            }
            if (!doorIsLocked())
            {
                this.callback.onCarEngineStateChanged("STOPPED", "Door Unlocked");
                return;
            }
            if (!powerIsReady())
            {
                this.callback.onCarEngineStateChanged("STOPPED", "No Power Available");
                return;
            }

            this.callback.onCarEngineStateChanged("STARTED", "Engine Started");
        }

        public void toggleTheLockDoorButton()
        {
            if (!doorIsLocked())
            {
                this.lockTheDoor();
            }
            else
            {
                this.unlockTheDoor();
            }
        }

        public void toggleTheDoorButton()
        {
            if (!doorIsClosed())
            {
                this.closeTheDoor();
            }
            else
            {
                this.openTheDoor();
            }
        }

        public void toggleThePowerButton()
        {
            if (!powerIsReady())
            {
                this.turnOnPower();
            }
            else
            {
                this.turnOffPower();
            }
        }
    }

    interface OnCarEngineStateChanged
    {
        void onCarEngineStateChanged(string value, string message);
    }
}