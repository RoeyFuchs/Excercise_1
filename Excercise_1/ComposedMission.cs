using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {
    public class ComposedMission : IMission {
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

        /// <summary>
        /// The function get a double, calculate by the all calculate functions
        /// and return the answer
        /// </summary>
        /// <param name="value"> 
        /// number as input (double)
        /// </param>
        /// <returns>
        /// numbner as return value (double)
        /// </returns>
        public double Calculate(double value) {
            foreach (var func in list) {
                value = func(value);
            }
            return value;
        }
        /// <summary>
        /// add another function to calculate with
        /// </summary>
        /// <param name="func">
        /// function to add
        /// </param>
        /// <returns>
        /// the Composed mission object (that you can use it again)
        /// </returns>
        public ComposedMission Add(aFunc func) {
            list.Add(func);
            return this;
        }
    }
}
