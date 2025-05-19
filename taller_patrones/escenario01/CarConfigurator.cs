namespace Escenario01
{
    abstract class CarConfigurator
    {
        public Car Auto { get; set; }

        public abstract void ConfigMotor();
        public abstract void ConfigTires();
        public abstract void ConfigColor();
        public abstract void ConfigAudioSystem();
        public abstract void ConfigSunroof();
        public abstract void ConfigGPS();
    }
}