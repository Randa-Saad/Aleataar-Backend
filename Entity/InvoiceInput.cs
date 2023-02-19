public class InvoiceInput{
         public string InvoiceNo { get; set; } = null!;
        public DateTime InvoiceDate { get; set; }
         public DateTime OrderDate { get; set; }

         public DateTime DelieveryDate { get; set; }
         public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string DAssistantId { get; set; } = null!;
        public string? DAssistantName { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? WhMp { get; set; }
        public string? Remarks { get; set; }
        public decimal? Total { get; set; }
        public decimal? Tax { get; set; }
        public decimal? NetTotal { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public List<InvoiceDetail>? details {get;set;}
}