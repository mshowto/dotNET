using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var personManager=PersonManager.CreateSingleton();
        }
    }


    class PersonManager
    {
        static PersonManager _personManager;
        static object _locked = new object();
        private PersonManager()
        {

        }

        public static PersonManager CreateSingleton()
        {
            lock (_locked)
            {
                if (_personManager == null)
                {
                    _personManager = new PersonManager();
                }
            }

            return _personManager;
        }
    }



}
