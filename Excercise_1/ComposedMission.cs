using System;
using System.Collections.Generic;

namespace Excercise_1 {
    public class ComposedMission : IMission {

        private const string TypeString = "Composed"; //const of type
        private List<customFunc> list; // list of all the function
        public event EventHandler<double> OnCalculate;  // An Event of when a mission is activated
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"> the name of the mission</param>
        public ComposedMission(string name) {
            Name = name;
            Type = TypeString;
            list = new List<customFunc>();
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
        /// The function get a double, calculate by the all calculate functions
        /// and return the answer
        /// </summary>
        /// <param name="value"> number as input (double)</param>
        /// <returns>numbner as return value (double)</returns>
        public double Calculate(double value) {
            foreach (var func in list) {
                value = func(value);
            }
            OnCalculate?.Invoke(this, value);
            return value;
        }
        /// <summary>
        /// add another function to calculate with
        /// </summary>
        /// <param name="func">function to add</param>
        /// <returns>the Composed mission object (that you can use it again)</returns>
        public ComposedMission Add(customFunc func) {
            list.Add(func);
            return this;
        }
    }
}
