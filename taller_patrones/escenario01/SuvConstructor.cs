namespace Escenario01
{
    class SuvConstructor : CarConfigurator
    {
        public SuvConstructor()
        {
            Auto = new Car("SUV");
        }

        public override void ConfigMotor()
        {
            Auto.AddOption("Motor", "V6");
        }

        public override void ConfigTires()
        {
            Auto.AddOption("Llantas", "4 de bajo perfil");
        }

        public override void ConfigColor()
        {
            Auto.AddOption("Color", "Negro");
        }

        public override void ConfigAudioSystem()
        {
            Auto.AddOption("SistemaAudio", "Premium");
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