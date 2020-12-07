namespace NOFactory
{
    public class FIAT : ICar
    {
        public string Name { get { return "FIAT"; }  }

        public void Move()
        {
            System.Console.WriteLine(Name + " moves");
        }
    }
}
