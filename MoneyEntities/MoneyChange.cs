namespace MoneyEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// Class representing the moneyChange table which stores all the information of the 
    /// currency and quantity provided to a customer
    /// </summary>
    /// <example>
    /// 111.50 
    /// Saves on the table 4 rows with the following information
    /// curency value £50    quantity 2 
    /// curency value £10    quantity 1 
    /// curency value £1     quantity 1 
    /// curency value 0.5p   quantity 1 
    /// </example>
    [Table("MoneyChange")]
    public partial class MoneyChange
    {
        public long Id { get; set; }

        public Guid MoneyChangeId { get; set; }

        public long? CurrencyId { get; set; }

        public decimal CurrencyValue { get; set; }

        public int? Quantity { get; set; }

        public DateTime RequestedTime { get; set; }

        public decimal Number { get; set; }
    }
}
