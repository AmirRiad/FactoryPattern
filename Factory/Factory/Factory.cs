using Factory.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Factory
{
    public class Factory : IFactory
    {
        readonly List<Type> Types;
        public Factory()
        {
            Types = Assembly.GetExecutingAssembly().GetTypes().Where(
                o => typeof(ICar).IsAssignableFrom(o) && o.IsClass && o.Name.ToLower().Contains(Settings.Default.CarType.ToLower()))
                .ToList();
        }
        public ICar Create()
        {
            var type = Types.FirstOrDefault(t => t.Name.ToLower() == Settings.Default.CarType.ToLower() + Settings.Default.Model.ToLower());
            return type == null ? new NonCar() : (ICar) Activator.CreateInstance(type);
        }
    }
}
