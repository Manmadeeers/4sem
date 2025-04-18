using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Celebrity_MSSQL
{
    public class LifeEvent
    {
        public LifeEvent() { }

        public int Id { get; set; }
        public int CelebrityId { get; set; }
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string? ReqPhotoPath { get; set; }

        //public virtual bool Update(LifeEvent lifeEvent);
    }
}
