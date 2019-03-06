using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {
    public class SingleMission : IMission {

        private const string TypeString = "Single";
        private aFunc calculateFunc;
        public SingleMission(aFunc calcFunc, string name) {
            calculateFunc = calcFunc;
            Name = name;
            Type = TypeString;
        }
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated

        public String Name { get; }
        public String Type { get; }
        /// <summary>
        /// The function get a double, calculate by the calculate function,
        /// and return the a
        /// </summary>
        /// <param name="value"> 
        /// number as input (double)
        /// </param>
        /// <returns>
        /// numbner as return value (double)
        /// </returns>
        public double Calculate(double value) { return calculateFunc(value); }
    }
}
