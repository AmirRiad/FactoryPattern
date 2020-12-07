namespace SimpleFactory
{
    public interface ICarFactory
    {
       ICar Create(string carType);
    }
}
