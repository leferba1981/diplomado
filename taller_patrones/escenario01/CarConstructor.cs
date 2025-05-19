namespace Escenario01
{
    class CarConstructor
    {
        public void ConfigOptions(CarConfigurator carConfigurator)
        {
            carConfigurator.ConfigMotor();
            carConfigurator.ConfigTires();
            carConfigurator.ConfigColor();
            carConfigurator.ConfigAudioSystem();
            carConfigurator.ConfigSunroof();
            carConfigurator.ConfigGPS();
        }
    }
}