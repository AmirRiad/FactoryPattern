namespace Factory
{
    public class KIA2010 : ICar
    {
        public string Name { get { return "KIA2010"; } }

        public void Move()
        {
            System.Console.WriteLine(Name + " moves");
        }
    }
}
