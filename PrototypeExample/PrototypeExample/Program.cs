using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone mobilePhone = new MobilePhone { Brand = "Apple", Model = "IPhone" };

            MobilePhone mobilePhone1 = (MobilePhone)mobilePhone.Clone();
            mobilePhone1.Brand = "Samsung";
            mobilePhone1.Model = "Galaxy";


        }
    }

    public abstract class Phone
    {
        public abstract Phone Clone();

        public string Brand { get; set; }
    }

    public class MobilePhone : Phone
    {
        public override Phone Clone()
        {
            return (Phone)MemberwiseClone();
        }

        public string Model { get; set; }
    }
}
