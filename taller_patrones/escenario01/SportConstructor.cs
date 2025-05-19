namespace Escenario01
{
    class SportConstructor : CarConfigurator
    {
        public SportConstructor()
        {
            Auto = new Car("Sport");
        }

        public override void ConfigMotor()
        {
            Auto.AddOption("Motor", "V8");
        }

        public override void ConfigTires()
        {
            Auto.AddOption("Llantas", "4 Todoterreno");
        }

        public override void ConfigColor()
        {
            Auto.AddOption("Color", "Rojo");
        }

        public override void ConfigAudioSystem()
        {
            Auto.AddOption("SistemaAudio", "Bose");
        }

        public override void ConfigSunroof()
        {
            Auto.AddOption("TechoSolar", "Sí");
        }

        public override void ConfigGPS()
        {
            Auto.AddOption("GPS", "Sí");
        }
    }
}