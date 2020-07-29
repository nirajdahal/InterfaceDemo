using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();
            KeyBoard keyboard = new KeyBoard();
            GameController gameController = new GameController();
            BatteryPoweredGmeController btryGm = new BatteryPoweredGmeController();
            controllers.Add(btryGm);
            controllers.Add(keyboard);
            controllers.Add(gameController);

            foreach(IComputerController controller in controllers)
            {
                if (controller is KeyBoard keybrd)
                {
                    keybrd.CurrentKeyPressed();
                }
                if(controller is GameController gmCntrl)
                {
                    gmCntrl.ChargeBattery();
                }
            }

            //using (GameController controller = new GameController())
            //{

            //};

            List<IBatteryPowered> btryPowered = new List<IBatteryPowered>();
            btryPowered.Add(new BatteryPoweredKeyboard());
            btryPowered.Add(new BatteryPoweredGmeController());
            Console.WriteLine("Hello World!");
        }
    }
}
