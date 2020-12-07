namespace Factory
{
    public class KIA2013 : ICar
    {
        public string Name { get { return "KIA2013"; } }

        public void Move()
        {
            System.Console.WriteLine(Name + " moves");
        }
    }
}
