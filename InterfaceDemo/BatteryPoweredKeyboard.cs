namespace InterfaceDemo
{
    public class BatteryPoweredKeyboard : KeyBoard, IBatteryPowered
    {
     
        public int BatteryLevel { get; set; }
    }
}
