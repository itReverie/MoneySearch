using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MoneySearchEntities
{
    public class MoneyClass
    {
        public long moneyId { get; set; }
        public decimal moneyValue { get; set; }
        public string moneyType { get; set; }

        public List<MoneyClass> GetAll()
        {
            List<MoneyClass> listMoney= new List<MoneyClass>();

            Model1 model = new Model1();
            foreach (Money element in model.Money.ToList())
            {
                MoneyClass newMonewElement = new MoneyClass();
                newMonewElement.moneyId = element.moneyId;
                newMonewElement.moneyValue = Convert.ToDecimal(element.moneyValue);
                newMonewElement.moneyType = element.moneyType;
                listMoney.Add(newMonewElement);
            }

            return listMoney;
        }
    }
}
