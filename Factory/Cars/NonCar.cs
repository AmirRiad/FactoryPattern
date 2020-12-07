namespace Factory
{
    public class NonCar : ICar
    {
        public string Name { get { return "nonCar"; } }

        public void Move()
        {
            System.Console.WriteLine(Name + " is  found");
        }
    }
}
