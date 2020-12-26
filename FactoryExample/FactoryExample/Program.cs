using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobilePhoneFactory = new MobilePhoneFactory();

            IMobilePhone mobilePhoneApple = mobilePhoneFactory.GetMobilePhone(MobilePhoneType.Apple);
            mobilePhoneApple.DisplayInfo();

            IMobilePhone mobilePhoneSamsung = mobilePhoneFactory.GetMobilePhone(MobilePhoneType.Samsung);
            mobilePhoneSamsung.DisplayInfo();
        }
    }

    public interface IMobilePhone
    {
        void DisplayInfo();
    }

    public class Apple : IMobilePhone
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Apple Iphone X");
        }
    }

    public class Samsung : IMobilePhone
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Samsung Galaxy S");
        }
    }
    public enum MobilePhoneType
    {
        Apple = 1,
        Samsung = 2
    }

    public interface IMobilePhoneFactory
    {
        IMobilePhone GetMobilePhone(MobilePhoneType type);
    }

    public class MobilePhoneFactory : IMobilePhoneFactory
    {
        public IMobilePhone GetMobilePhone(MobilePhoneType type)
        {
            IMobilePhone mobilePhone = null;
            switch (type)
            {
                case MobilePhoneType.Apple:
                    mobilePhone = new Apple();
                    break;
                case MobilePhoneType.Samsung:
                    mobilePhone = new Samsung();
                    break;
            }
            return mobilePhone;
        }
    }
}
