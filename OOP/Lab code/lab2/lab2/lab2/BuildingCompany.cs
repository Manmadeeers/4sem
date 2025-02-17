namespace lab2
{
    public enum CompanyTypes
    {
        LLC = 1,
        SP,
        LTD,
        INC
    }
    public class BuildingCompany
    {
        private string _name;
        private string _address;
        private string _registration_number;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string RegistrationNumber
        {
            get { return _registration_number; }
            set { _registration_number = value; }
        }
    }
}
