namespace Exercise1
{
    namespace Models
    {
        public class App
        {
            private string Name;
            private float Size;

            public App(string name, float size)
            {
                this.Name = name;
                this.Size = size;
            }

            public float GetApplicationSize()
            {
                return this.Size;
            }
        }
    }
}