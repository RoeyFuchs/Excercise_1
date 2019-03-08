using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {
    public class SingleMission : IMission {

        private const string TypeString = "Single"; //const of type
        private customFunc calculateFunc; //function to calculate with

        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="calcFunc">function to calculate with</param>
        /// <param name="name">the name of the mission</param>
        public SingleMission(customFunc calcFunc, string name) {
            calculateFunc = calcFunc;
            Name = name;
            Type = TypeString;
        }


        /// <summary>
        /// Properties of Name
        /// </summary>
        public String Name { get; }
        /// <summary>
        /// Properties of Type
        /// </summary>
        public String Type { get; }
        /// <summary>
        /// The function get a double, calculate by the calculate function,
        /// and return the a
        /// </summary>
        /// <param name="value">number as input (double)</param>
        /// <returns>numbner as return value (double)</returns>
        public double Calculate(double value) {
            double ans = calculateFunc(value);
            OnCalculate?.Invoke(this, value);
            return ans;
        }
    }
}
