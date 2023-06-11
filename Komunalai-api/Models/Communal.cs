namespace Komunalai_api.Models
{
    public class Communal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? Type { get; set; }
        public string? Commune { get; set; }
        public double Before { get; set; }
        public double After { get; set; }
        public double Difference { get; set; }
        public double Price { get; set; }
        public double Calculated { get; set; }
        public double AdditionalTax { get; set; }
        public double Sum { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? Comment { get; set; }
    }
}
