using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private const string TypeString = "Single";
        private aFunc calculateFunc;

        SingleMission(aFunc calcFunc, string name)
        {
            calculateFunc = calcFunc;
            Name = name;
            Type = TypeString;
        }

        event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        String Name { get; }
        String Type { get; }

        double Calculate(double value) {}
    }
}
