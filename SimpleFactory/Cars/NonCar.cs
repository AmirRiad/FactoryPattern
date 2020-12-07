namespace SimpleFactory
{
    public class NonCar : ICar
    {
        public string Name { get { return "KIA"; } }

        public void Move()
        {
            System.Console.WriteLine(Name + " is  found");
        }
    }
}
