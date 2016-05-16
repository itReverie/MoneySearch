namespace MoneySearchEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MoneySearches
    {
        public long Id { get; set; }

        public long? searchId { get; set; }

        public long? moneyId { get; set; }

        public int? quantity { get; set; }
    }
}
