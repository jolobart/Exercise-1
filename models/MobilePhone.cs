namespace Exercise1
{
    namespace Models
    {
        public class MobilePhone
        {
            private string Brand;
            private string Color;
            private SimCard SimCard;
            private string Model;

            public MobilePhone(string brand, string color, SimCard simCard, string model)
            {
                this.Brand = brand;
                this.Color = color;
                this.SimCard = simCard;
                this.Model = model;
            }

            public string GetPhoneNumber()
            {
                return this.SimCard.GetPhoneNumber();
            }

            public void SwapSimCard(SimCard simCard)
            {
                this.SimCard = simCard;
            }

            public string Call(string phoneNumber)
            {
                return "Calling " + phoneNumber + " from number " + this.GetPhoneNumber() + ".";
            }

            public string Call(MobilePhone mobilePhone)
            {
                return "Calling " + mobilePhone.GetPhoneNumber() + " from number " + this.GetPhoneNumber() + ".";
            }

            public string GetPhoneModel()
            {
                return this.Model;
            }
        }
    }
}