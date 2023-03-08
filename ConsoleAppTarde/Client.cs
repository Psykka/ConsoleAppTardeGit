namespace ConsoleAppTarde
{
    public class Client
    {
        private int Id;
        private string Name;
        private string Phone;

        public Client(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetPhone()
        {
            return Phone;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetPhone(string phone)
        {
            Phone = phone;
        }
    }
}
