using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary
{
    class EventService
    {
        EventDataAccess eventDataAccess;

        public EventService()
        {
            this.eventDataAccess = new EventDataAccess();
        }
        public int AddnewEntities(string date,string eventName,string description,string importance)
        {
            EventEntities eventEntities = new EventEntities()
            {
                Date = date,
                EventName = eventName,
                Description = description,
                Importance = importance

            };
            eventDataAccess = new EventDataAccess();
            return this.eventDataAccess.AddNewEvents(eventEntities);


        }

        public List<EventEntities> GetDataList()
        {
           
            return this.eventDataAccess.GellAllData();
        }
    }
}
