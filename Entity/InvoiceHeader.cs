public class InvoiceHeader{
        public Boolean? Checked { get; set; }
        public string InvoiceNo { get; set; } = null!;
        public DateTime InvoiceDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? WhMp { get; set; }
        public string? Type { get; set; }
        public string? Restricted { get; set; }
        public DateTime? DelieveryDate { get; set; }
        public string CustomerId { get; set; } = null!;
        public string? CustomerName { get; set; }
        public string DAssistantId { get; set; }
        public string? DAssistantName { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? Remarks { get; set; }
        public decimal? Total { get; set; }
        public decimal? Tax { get; set; }
        public decimal? NetTotal { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
}