namespace Demo.Core.Enitites
{
    public class OrderDetail
    {
      public int OrderDetailId { get; set; }
     

        public Product Product { get; set; }

        public int Count { get; set; }
    }
}
