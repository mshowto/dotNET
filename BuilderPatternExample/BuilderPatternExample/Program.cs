using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirector phoneDirector = new PhoneDirector();
            var newBuilder = new NewPhoneBuilder();
            phoneDirector.GeneratePhone(newBuilder);

            var model = newBuilder.GetData();

            Console.WriteLine(model.Brand);
        }
    }

    class PhoneViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }

    abstract class PhoneBuilder
    {
        public abstract void GetPhoneData();
        public abstract void SetPrice();
        public abstract PhoneViewModel GetData();
    }

    class NewPhoneBuilder : PhoneBuilder
    {
        PhoneViewModel model = new PhoneViewModel();
        public override void GetPhoneData()
        {
            model.Brand = "Apple";
            model.Model = "Iphone X";
        }
        public override void SetPrice()
        {
            model.Price = 10000;
        }
        public override PhoneViewModel GetData()
        {
            return model;
        }
    }

    class OldPhoneBuilder : PhoneBuilder
    {
        PhoneViewModel model = new PhoneViewModel();
        public override void GetPhoneData()
        {
            model.Brand = "Nokia";
            model.Model = "3310";
        }

        public override void SetPrice()
        {
            model.Price = 300;
        }

        public override PhoneViewModel GetData()
        {
            return model;
        }

    }

    class PhoneDirector
    {
        public void GeneratePhone(PhoneBuilder phoneBuilder)
        {
            phoneBuilder.GetPhoneData();
            phoneBuilder.SetPrice();
        }
    }
}
