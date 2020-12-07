namespace NOFactory
{
    public class NonCar : ICar
    {
        public string Name { get { return "NonCar"; } }

        public void Move()
        {
            System.Console.WriteLine( Name +" is  found");
        }
    }
}
