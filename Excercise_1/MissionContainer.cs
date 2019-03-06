using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double aFunc(double val);
    public class FunctionsContainer
    {
        private Dictionary<string, aFunc> dic;

        public aFunc this[string str]
        {
            get {
                //check if we have the key and return the value (the function)
                if(dic.ContainsKey(str)) {
                    return dic[str];
                }
                //if we don't have the key in the dictinary, return a deafult function 
                return (val => val);
            }
            //add a function to the dictionary
            set { dic[str] = value; }
        }

        FunctionsContainer()
        {
            dic = new Dictionary<string, aFunc>();
        }



    }
}


}
