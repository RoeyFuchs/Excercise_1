
using System.Collections.Generic;

namespace Excercise_1 {
    public delegate double customFunc(double val);

    public class FunctionsContainer {
        private customFunc defualtFunction = val => val; // the deafualt function (f(x) = x)
        private Dictionary<string, customFunc> dic; //the dictionary to save the key and value

        /// <summary>
        /// constructor
        /// </summary>
        public FunctionsContainer() {
            dic = new Dictionary<string, customFunc>();
        }

        /// <summary>
        /// Properties as index (dictionary)
        /// </summary>
        /// <param name="str">key to search</param>
        /// <returns>value of the key</returns>
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

        /// <summary>
        /// get the all keys in the container
        /// </summary>
        /// <returns>enumerable of the names</returns>
        public IEnumerable<string> getAllMissions() {
            Queue<string> queue = new Queue<string>();
            foreach (var entry in dic) {        
                queue.Enqueue(entry.Key);
            }
            return queue as IEnumerable<string>;
        }


    }
}
