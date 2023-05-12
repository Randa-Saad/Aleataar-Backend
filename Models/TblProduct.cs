using System;
using System.Collections.Generic;

namespace SalesOrderAPI.Models
{
    public partial class TblProduct
    {
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalizedPrice { get; set; }
        public decimal? SegmentedPrice { get; set; }
        public decimal? ConsumedPrice { get; set; }
        public int? CountedCtns { get; set; }
        public int? CountedBoxes { get; set; }
        public int? CountedPieces { get; set; }
        public int? Category { get; set; }
        public string? Remarks { get; set; }
    }
}
