namespace Factory
{
    public class BMW2013 : ICar
    {
        public string Name { get { return "BMW2013"; } }

        public void Move()
        {
            System.Console.WriteLine(Name + " moves");
        }
    }
}
