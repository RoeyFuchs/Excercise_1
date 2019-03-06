using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private const string TypeString = "Composed";
        private List<aFunc> list;
        public ComposedMission(string name) {
            Name = name;
            Type = TypeString;
            list = new List<aFunc>();
        }
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        public String Name { get; }
        public String Type { get; }

        public double Calculate(double value)
        {
            foreach(var func in list)
            {
                value = func(value);
            }
            return value;
        }
        public ComposedMission Add(aFunc func)
        {
            list.Add(func);
            return this;
        }
    }
}
