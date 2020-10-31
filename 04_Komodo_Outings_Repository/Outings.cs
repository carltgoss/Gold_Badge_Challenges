using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Komodo_Outings_Repository
{
    public class Outings
    {
        public EventType EventType { get; set; }
        public int PeopleAttended { get; set; }
        public DateTime Date { get; set; }
        public double CostPerPerson { get; set; }
        public double EventCost { get; set; }

        public Outings() { }
        public Outings(EventType eventType, int peopleAttended, DateTime date, double costPerPerson, double eventCost)
        {
            EventType = eventType;
            PeopleAttended = peopleAttended;
            Date = date;
            CostPerPerson = costPerPerson;
            EventCost = eventCost;

        }


    }
    public enum EventType
    {
        Golf = 1,
        Bowling,
        AmusementPark,
        Concert
    }
}
