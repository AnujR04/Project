namespace Project.MyProject.DAL
{
    public class Sales
    {
        public int SalesId { get; set; }
        public int ProductId { get; set;}
        public DateTime SalesDate { get; set; }
        public Product Product { get; set;}
        public int Quantity { get; set;}
        public decimal Amount { get; set; }
    }
}
