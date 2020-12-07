using Factory;
using SimpleFactory;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region  factory
            Factory.IFactory factory = new Factory.Factory();
            Factory.ICar carFactory = factory.Create();
            carFactory.Move();
            Console.ReadLine();

            #endregion

            //#region simple factory
            //SimpleFactory.ICarFactory simpleFactory = new AnyFactory();
            //SimpleFactory.ICar simpleCarFactory = simpleFactory.Create("KIA");
            //simpleCarFactory.Move();
            //Console.ReadLine();

            //#endregion



            //#region nonfactory

            //NOFactory.ICar car = GetCar("fiat");
            //car.Move();
            //Console.ReadLine();

            //#endregion

        }

        private static NOFactory.ICar GetCar(string carType)
        {
            NOFactory.ICar car;
            switch (carType.ToLower())
            {
                case "bmw":
                    car = new NOFactory.BMW();
                    break;

                case "kia":
                    car = new NOFactory.KIA();
                    break;

                case "fiat":
                    car = new NOFactory.FIAT();
                    break;

                default:
                    car = new NOFactory.NonCar();
                    break;
            }

            return car;
        }
    }
}
