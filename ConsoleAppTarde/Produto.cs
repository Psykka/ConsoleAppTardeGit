namespace ConsoleAppTarde
{
    public class Product
    {
        private int Id;
        private string Name;
        private decimal Value;

        public Product(int id, string name, decimal value)
        {
            Id = id;
            Name = name;
            Value = value;
        }

        public int GetId ()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public decimal GetValue()
        {
            return Value;
        }

        public void SetId (int id)
        {
            Id = id;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetValue(decimal value)
        {
            if (value > 0)
            {
                Value = value;
            }
        }
    }
}
