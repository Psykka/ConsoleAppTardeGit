namespace ConsoleAppTarde
{
    public class Produto
    {
        private int Id;
        private string Name;
        private decimal Value;

        public Produto(int id, string name, decimal value)
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
    }
}
