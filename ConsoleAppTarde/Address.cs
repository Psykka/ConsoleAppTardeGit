namespace ConsoleAppTarde
{
    internal class Address
    {
        private int Id;
        private string CEP;
        private string Street;
        private int Number;
        private string District;
        private string City;

        public Address(int id, string cep, string street, string district, string city)
        {
            Id = id;
            CEP = cep;
            Street = street;
            District = district;
            City = city;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetCEP()
        {
            return CEP;
        }

        public string GetStreet()
        {
            return Street;
        }

        public int GetNumber()
        {
            return Number;
        }

        public string GetDistrict()
        {
            return District;
        }

        public string GetCity()
        {
            return City;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetCEP(string cep)
        {
            CEP = cep;
        }

        public void SetStreet(string street)
        {
            Street = street;
        }

        public void SetNumber(int number)
        {
            Number = number;
        }

        public void SetDistrict(string district)
        {
            District = district;
        }

        public void SetCity(string city)
        {
            City = city;
        }
    }
}
