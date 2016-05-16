
using MoneySearchEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoneySearchMvcApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<String> Get()
        {
            //Money money = new Money();
            //money.getMoney();
            //MoneySearchModel moneySearchModel = new MoneySearchModel();
            //List<Money> money = moneySearchModel.Money.ToList();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}