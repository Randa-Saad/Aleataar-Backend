public class ProductEntity{
         public string Code { get; set; } = null!;
         public string? Name { get; set; }
         public decimal? Price { get; set; }
         public decimal? TotalizedPrice { get; set; }
         public decimal? SegmentedPrice { get; set; }
         public decimal? ConsumedPrice { get; set; }
         public int? CountedCtns { get; set; }
         public int? CountedBoxes { get; set; }
         public int? CountesPieces { get; set; }
         public int? Category { get; set; }
         public string? productImage { get; set; }
         public string? Remarks { get; set; }
         public List<ProductVariantEntity>? Variants { get; set; }
}