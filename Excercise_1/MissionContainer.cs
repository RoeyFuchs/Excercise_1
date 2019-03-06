using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {
    public delegate double aFunc(double val);
    public class FunctionsContainer {
        private aFunc defualtFunction = val => val;
        private Dictionary<string, aFunc> dic;

        public aFunc this[string str] {
            get {
                //if we don't have the key in the dictinary, add a defualt function
                if (!dic.ContainsKey(str)) {
                    dic[str] = defualtFunction;
                }
                return dic[str];
            }
            //add a function to the dictionary
            set { dic[str] = value; }
        }

        public FunctionsContainer() {
            dic = new Dictionary<string, aFunc>();
        }
    }
}
