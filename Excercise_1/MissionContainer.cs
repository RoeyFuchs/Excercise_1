using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {
    public delegate double customFunc(double val);
    public class FunctionsContainer {
        private customFunc defualtFunction = val => val;
        private Dictionary<string, customFunc> dic;

        public customFunc this[string str] {
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
            dic = new Dictionary<string, customFunc>();
        }
    }
}
