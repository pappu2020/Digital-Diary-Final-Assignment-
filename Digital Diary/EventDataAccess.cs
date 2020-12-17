using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary
{
    class EventDataAccess
    {
        DataAccess dataaccess;

        public EventDataAccess()
        {
            this.dataaccess = new DataAccess();
        }

        public int AddNewEvents(EventEntities eventEntities)
        {
            string sql = "INSERT INTO Events(Date,EventName,Description,Importance) VALUES('"+eventEntities.Date+"','"+eventEntities.EventName+"','"+eventEntities.Description+"','"+eventEntities.Importance+"')";
            return this.dataaccess.ExecuteQuery(sql);
        }

        public List<EventEntities> GellAllData()
        {
            string sql = "SELECT * FROM Events";
            SqlDataReader reader = this.dataaccess.GetData(sql);
            List<EventEntities> events = new List<EventEntities>();
            while (reader.Read())
            {
                EventEntities en = new EventEntities();
                en.Date = reader["Date"].ToString();
                en.EventName = reader["EventName"].ToString();
                en.Description = reader["Description"].ToString();
                en.Importance = reader["Importance"].ToString();
                events.Add(en);

            }
            return events;

        }


    }
}
