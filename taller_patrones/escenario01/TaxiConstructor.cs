namespace Escenario01
{
    class TaxiConstructor : CarConfigurator
    {
        public TaxiConstructor()
        {
            Auto = new Car("Taxi");
        }
        
        public override void ConfigMotor()
        {
            Auto.AddOption("Motor", "4 cilindros");
        }
        
        public override void ConfigTires()
        {
            Auto.AddOption("Llantas", "4 llantas de uso pesado");
        }
        
        public override void ConfigColor()
        {
            Auto.AddOption("Color", "Amarillo");
        }
        
        public override void ConfigAudioSystem()
        {
            Auto.AddOption("Sistema de Audio", "Básico");
        }
        
        public override void ConfigSunroof()
        {
            Auto.AddOption("Techo Solar", "No disponible");
        }
        
        public override void ConfigGPS()
        {
            Auto.AddOption("GPS", "Sistema de navegación básico");
        }
    }
}