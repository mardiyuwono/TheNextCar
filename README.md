# # The Next Car
(Introduction)

Aplikasi ini merupakan sebuah program yang menerapkan konsep MVC (Model View Controller).
## Scope of functionalities
-   User bisa menekan tombol  `STARTED/STOPPED`,  `OPENED/CLOSED`,  `LOCKED/UNCLOCKED`, dan  `ON/OFF`
-   User hanya bisa menekan `STARTED` ketika kondisi  "Close The Door, Door Locked dan Power is ON"
## How does it works?
-   Terdapat folder Model yang berisikan class  `Door.cs`  dan  `AccuBattery.cs`
-   Terdapat`MainWindow.xaml`untuk menampilkan program
-   Terdapat folder Controller yang berisi class  `AccuBatteryController.cs`  `DoorController.cs`  dan  `Car.cs`
-   Terdapat class `MainWindow.xaml.cs` untuk function
