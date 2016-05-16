using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySearchEntities
{
    public class SearchClass
    {
        public long id { get; set; }
        public long searchId { get; set; }
        public long moneyId{ get; set; }
        public int quantity{ get; set; }

        public List<SearchClass> GetAllSearches()
        {
            List<SearchClass> listAllSearches= new List<SearchClass>();

            Model1 model = new Model1();
            foreach (MoneySearches element in model.MoneySearches.ToList())
            {
                SearchClass newMoneySearchElement = new SearchClass();
                newMoneySearchElement.id = Convert.ToInt32(element.Id);
                newMoneySearchElement.searchId =  Convert.ToInt32(element.searchId);
                newMoneySearchElement.moneyId =  Convert.ToInt32(element.moneyId);
                newMoneySearchElement.quantity =  Convert.ToInt16(element.quantity);
                listAllSearches.Add(newMoneySearchElement);
            }

            return listAllSearches;
        }

    }
}
