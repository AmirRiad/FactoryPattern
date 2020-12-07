using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SimpleFactory
{
    public class AnyFactory : ICarFactory
    {

        //Refelction  Assembly & Activator

        readonly List<Type> Types;
        public AnyFactory()
        {
            Types = Assembly.GetExecutingAssembly().GetTypes().Where(
                o => typeof(ICar).IsAssignableFrom(o) && o.IsClass)
                .ToList();
        }
        public ICar Create(string carType)
        {
            var type = Types.FirstOrDefault(t => t.Name.ToLower() == carType.ToLower());
            return type == null ? new NonCar() : (ICar) Activator.CreateInstance(type);
        }
    }
}
