namespace DAL_Celebrity
{
    public interface IMix<T1, T2>
    {
        List<T2>GetLifeEventsByCelebrityId(int celebrityId);
        T1? GetCelebrityByLifeEventId(int lifeEventId);
    }

    public interface ICelebrity<T1>:IDisposable
    {
        List<T1> GetAllCelebrities();
        T1? GetCelebrityById(int id);
        bool DeleteCelebrity(int id);
        bool AddCelebrity(T1 celebrity);
        bool UpdateCelebrity(int id,T1 celebrity);
        int GetCelebrityByName(string name);
    }

    public interface ILifeEvent<T2> 
    {
        List<T2> GetAllLifeEvents();
        T2? GetLifeEventById(int lifeEventId);
        bool DeleteLifeEvent(int lifeEventId);
        bool AddLifeEvent(T2 lifeEvent);
        bool UpdateLifeEvent(int id,T2 lifeEvent);

    }

    public interface IRepository<T1, T2> : IMix<T1, T2>, ICelebrity<T1>, ILifeEvent<T2>
    {

    }

}
