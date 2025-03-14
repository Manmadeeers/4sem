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
    public class Repository
    {

    }
}
