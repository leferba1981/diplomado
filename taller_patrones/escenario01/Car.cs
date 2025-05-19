namespace Escenario01
{
    public class Car
    {
        string carType;
        Dictionary<string, string> options = new Dictionary<string, string>();

        public Car(string carType)
        {
            this.carType = carType;
        }

        public void GetConfigOptions()
        {
            foreach (var option in options)
            {
                Console.WriteLine($"{option.Key}: {option.Value}");
            }
        }
        
        public void AddOption(string key, string value)
        {
            options.Add(key, value);
        }
    }
}