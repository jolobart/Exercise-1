namespace Exercise1
{
    namespace Models
    {
        public class SimCard
        {
            private string PhoneNumber;
            private string Network;

            public SimCard(string phoneNumber, string network)
            {
                this.PhoneNumber = phoneNumber;
                this.Network = network;
            }

            public string GetPhoneNumber() {
                return this.PhoneNumber;
            }
        }
    }
}