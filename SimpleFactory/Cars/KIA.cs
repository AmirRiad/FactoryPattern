namespace SimpleFactory
{
    public class KIA : ICar
    {
        public string Name { get { return "KIA"; } }

        public void Move()
        {
            System.Console.WriteLine(Name + " moves");
        }
    }
}
