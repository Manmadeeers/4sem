using Microsoft.EntityFrameworkCore;
using Exceptions;
namespace DAL_Celebrity_MSSQL
{
    public interface IRepository : DAL_Celebrity.IRepository<Celebrity, LifeEvent> { }
    public class Repository : IRepository
    {
        Context context;
        public Repository() { this.context = new Context(); }
        public Repository(string connectionString) { this.context = new Context(connectionString); }
        public static IRepository Create() { return new Repository(); }
        public static IRepository Create(string connectionString) { return new Repository(connectionString); }
        public List<Celebrity> GetAllCelebrities() { return this.context.Celebrities.ToList<Celebrity>(); }
        public Celebrity? GetCelebrityById(int id) { return this.context.Celebrities.FirstOrDefault(c => c.Id == id); }
        public bool AddCelebrity(Celebrity celebrity)
        {
            if (this.context.Celebrities.Add(celebrity) is not null)
            {
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool DeleteCelebrity(int id)
        {
            Celebrity? celebrity = this.context.Celebrities.FirstOrDefault(c => c.Id == id);
            if (celebrity is not null)
            {
                this.context.Celebrities.Remove(celebrity);
                context.SaveChanges();
                return true;

            }
            else
            {
                return false;
            }
        }


        public bool UpdateCelebrity(int id, Celebrity celebrity)
        {
            Celebrity? celeb = this.context.Celebrities.FirstOrDefault(c => c.Id == id);
            if (celeb != null)
            {
                celeb.FullName = celebrity.FullName;
                celeb.Nationality = celebrity.Nationality;
                celeb.ReqPhotoPath = celebrity.ReqPhotoPath;
                this.context.Celebrities.Update(celeb);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<LifeEvent> GetAllLifeEvents() { return this.context.LifeEvents.ToList<LifeEvent>(); }

        public LifeEvent? GetLifeEventById(int lifeEventId) { return this.context.LifeEvents.FirstOrDefault(l => l.Id == lifeEventId); }

        public bool AddLifeEvent(LifeEvent lifeEvent)
        {
            if (this.context.LifeEvents.Add(lifeEvent) is not null)
            {
                context.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteLifeEvent(int lifeEventId)
        {
            LifeEvent? lifeEvent = this.context.LifeEvents.FirstOrDefault(l => l.Id == lifeEventId);
            if (lifeEvent != null)
            {
                this.context.LifeEvents.Remove(lifeEvent);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateLifeEvent(int id, LifeEvent lifeEvent)
        {
            LifeEvent? lifeEv = this.context.LifeEvents.FirstOrDefault(l => l.Id == id);
            if(lifeEv != null)
            {
                lifeEv = lifeEvent;
                this.context.LifeEvents.Update(lifeEv);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;   
            }
        }


        public List<LifeEvent> GetLifeEventsByCelebrityId(int celebrityId)
        {
            return this.context.LifeEvents.Where(l=>l.CelebrityId==celebrityId).ToList<LifeEvent>();
        }

        public Celebrity? GetCelebrityByLifeEventId(int lifeEventId)
        {
            LifeEvent? lifeEvent = this.context.LifeEvents.FirstOrDefault(l => l.Id == lifeEventId);
            if(lifeEvent != null)
            {
                return this.context.Celebrities.FirstOrDefault(c => c.Id == lifeEvent.CelebrityId);
            }
            else
            {
                return null;
            }
        }

        public int GetCelebrityByName(string name)
        {
            Celebrity? celebrity = this.context.Celebrities.FirstOrDefault(c => c.FullName.Contains(name));
            if (celebrity != null)
            {
                return celebrity.Id;
            }
            else
            {
                return 0;
            }

        }


        public void Dispose() { }

    }


}
