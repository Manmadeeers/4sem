namespace DAL_Celebrity_MSSQL
{
    public class CelebritiesConfig
    {
        public string PhotosFolder { get; set; }
        public string ConnectionString { get; set; }

        public string PhotosRequestPath { get; set; }

        public string CountryCodesPath { get; set; }
    }
}