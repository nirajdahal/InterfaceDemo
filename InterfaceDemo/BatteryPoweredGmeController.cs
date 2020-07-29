namespace InterfaceDemo
{
    public class BatteryPoweredGmeController : GameController,  IBatteryPowered
    {
        public int BatteryLevel { get; set; }
    }
}
