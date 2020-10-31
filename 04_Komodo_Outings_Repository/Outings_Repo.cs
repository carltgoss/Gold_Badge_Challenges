using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Komodo_Outings_Repository
{
    public class Outings_Repo
    {
        private List<Outings> _outingsList = new List<Outings>();
       

        public bool AddOutingsToList(Outings outing)
        {
            int startingCount = _outingsList.Count;

            _outingsList.Add(outing);

            bool wasAdded = (_outingsList.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<Outings> GetOutings()
        {
            return _outingsList;
        }

        public double AddEventCosts
        {
            get
            {
                double costTotal = 0;
                foreach(var outing in _outingsList)
                {
                    costTotal += Outings.;
                }
                return costTotal;
            }
        }
       
        
    }
}
