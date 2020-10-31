using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Komodo_Claims_Repository
{
    public class Claims_Repo
    {
        
        private Queue<Claims> _allClaims = new Queue<Claims>();
        

        public bool AddClaimsToQueue(Claims newClaims)
        {
            int startingCount = _allClaims.Count;

            _allClaims.Enqueue(newClaims);

            bool wasAdded = (_allClaims.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public Queue<Claims> GetClaims()
        {
            return _allClaims;
        }
    }
}
