namespace Factory
{
    public class BMW2010 : ICar
    {
        public string Name { get { return "BMW2010"; } }

        public void Move()
        {
            System.Console.WriteLine(Name + " moves");
        }
    }
}
