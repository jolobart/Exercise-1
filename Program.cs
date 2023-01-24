using Exercise1.Models;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 2 instances of a SimCard
            SimCard sim = new SimCard("09170000000", "Globe");
            SimCard sim2 = new SimCard("09171111111", "Smart");

            // 2 instances of a MobilePhone
            MobilePhone nokia = new MobilePhone("Nokia", "Gray", sim, "Nokia 5110");
            MobilePhone motorola = new MobilePhone("Motorola", "White", sim2, "Motorola I1000 Plus");

            // 2 instances of a SmartPhone
            SmartPhone iPhone = new SmartPhone("Apple", "Space Gray", sim, "IPhone 14 Pro Max", "Safari");
            SmartPhone samsungFlip = new SmartPhone("Samsung", "Pink Gold", sim2, "Galaxy Z Flip", "Chrome");

            // 2 instances of an Application
            App facebook = new App("Facebook", 152.34f);
            App instagram = new App("Instagram", 234.44f);

            // MobilePhone talking to another MobilePhone
            Console.WriteLine(motorola.Call(nokia));

            // SmartPhone talking to another SmartPhone
            Console.WriteLine(iPhone.Call(samsungFlip));

            // Adding applications to a SmartPhone
            iPhone.AddApplication(facebook);
            iPhone.AddApplication(instagram);
            samsungFlip.AddApplication(facebook);

            // Displaying the total size of the applications of a smart phone
            Console.WriteLine(iPhone.GetPhoneModel() + " total size: " + iPhone.GetTotalSize());
            Console.WriteLine(samsungFlip.GetPhoneModel() + " total size: " + samsungFlip.GetTotalSize());
        }
    }
}