namespace Exercise1
{
    namespace Models
    {
        public class SmartPhone : MobilePhone
        {
            private string Browser;
            private List<App> Application;

            public SmartPhone(string brand, string color, SimCard simCard, string model, string browser) : base(brand, color, simCard, model)
            {
                this.Browser = browser;
                this.Application = new List<App>();
            }

            public string CallFromBrowser(string phoneNumber)
            {
                return "Calling from " + this.Browser + ". " + this.Call(phoneNumber);
            }

            public string CallFromBrowser(MobilePhone mobilePhone)
            {
                return "Calling from " + this.Browser + ". " + this.Call(mobilePhone);
            }

            public void AddApplication(App app)
            {
                this.Application.Add(app);
            }

            public float GetTotalSize()
            {
                return this.Application.Sum(app => app.GetApplicationSize());
            }
        }
    }
}