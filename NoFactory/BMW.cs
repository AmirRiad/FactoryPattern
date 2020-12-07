namespace NOFactory
{
    public class BMW : ICar
    {
        public string Name { get { return "BMW"; }  }

        public void Move()
        {
            System.Console.WriteLine(Name + " moves");
        }
    }
}
