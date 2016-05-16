namespace MoneySearchEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Money")]
    public partial class Money
    {
        public long moneyId { get; set; }

        public decimal? moneyValue { get; set; }

        [StringLength(50)]
        public string moneyType { get; set; }
    }
}
