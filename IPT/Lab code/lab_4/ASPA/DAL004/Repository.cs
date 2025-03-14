using System.Text.Json;

namespace DAL004
{
    interface IRepository:IDisposable
    {
        string BasePath { get; }
        Celebrity[] GetAllCelebrities();
        Celebrity? GetCelebrityById(int id);
        Celebrity[] GetCelebritiesBySurename(string surename);
        string? GetPhotoPathById(int id);
        int? addCelebrity(Celebrity celeb);

        bool delCelebrity(int id);
        int? updCelebrityById(int id , Celebrity celeb);
        int saveChanges();
    }

    public record Celebrity(int Id, string Firstname, string Surname, string PhotoPath);
    public class Repository:IRepository
    {

        public string JSONFileName = "Celebrities.json";
        public string BasePath { get; }//path to directory where json file is located
        public string FullFilePath { get; }//full path to json file with celebrities
        public List<Celebrity> celebrities;

        public Repository(string dirPath)
        {
            this.BasePath = Path.Combine(Directory.GetCurrentDirectory(), dirPath);
            this.FullFilePath = Path.Combine(BasePath,JSONFileName);
            try
            {
                var jsonString = File.ReadAllText(this.FullFilePath);
                celebrities = JsonSerializer.Deserialize<List<Celebrity>>(jsonString) ?? new List<Celebrity>();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }


        public Celebrity[] GetAllCelebrities()
        {
            return this.celebrities.ToArray();
        }

        public Celebrity? GetCelebrityById(int id)
        {
            return this.celebrities.FirstOrDefault(c=>c.Id == id);
        }

        public Celebrity[] GetCelebritiesBySurename(string surename)
        {
            return this.celebrities.Where(c=>c.Surname== surename).ToArray();
        }

        public string? GetPhotoPathById(int id)
        {
            return this.GetCelebrityById(id)?.PhotoPath;
        }

        public int? addCelebrity(Celebrity celeb)
        {
            this.celebrities.Add(celeb);
            return celeb.Id;
        }

        public bool delCelebrity(int id)
        {
            if(celebrities.Find(c => c.Id == id) == null)
            {
                return false;
            }
            else
            {
                this.celebrities.RemoveAt(this.celebrities.FindIndex(c => c.Id == id));
                return true;
            }
        }

        public int? updCelebrityById(int id, Celebrity celeb)
        {
            if (this.celebrities.Find(c => c.Id == id) == null)
            {
                return -1;
            }
            else
            {
                this.celebrities[this.celebrities.FindIndex(c=>c.Id==id)] = celeb;
                return id;
            }
        }

        public int saveChanges()
        {
            int beforeUpdLength = File.ReadAllText(this.FullFilePath).Length;
            var updatedJsonString = JsonSerializer.Serialize(this.celebrities);
            File.WriteAllText(this.FullFilePath, updatedJsonString);
            int afterUpdLength = File.ReadAllText(this.FullFilePath).Length;

            return afterUpdLength - beforeUpdLength;
        }

        public void Dispose()
        {

        }
    }
}
