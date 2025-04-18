namespace DAL_Celebrity
{
    public  class Celebrity
    {
        public Celebrity() { this.FullName = string.Empty;this.Nationality = string.Empty; }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }

        public string? ReqPhotoPath { get; set; }

        //public  virtual bool Update(Celebrity celebrity);
    }

    public class LifeEvent
    {
        public LifeEvent() { }

        public int Id { get; set; }
        public int CelebrityId { get; set;}
        public DateTime Date { get; set;}

        public string Description { get; set; }

        public string? ReqPhotoPath { get; set; }

        //public virtual bool Update(LifeEvent lifeEvent);
    }

}
