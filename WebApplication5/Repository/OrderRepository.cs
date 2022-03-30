using WebApplication5.Models;

namespace WebApplication5.Repository
{
    public class OrderRepository : IOrderRepository
    {
        //remove comments
        //private readonly DbContextClass<ApplicationDbContext> _DbContext;
        //public OrderRepository(DbContextClass<ApplicationDbContext> dbcontxt)
        //{
        //    _DbContext = dbcontxt;
        //}
        public async Task<bool> AddOrder(OrderHeader orderHeader)
        {
            //await using var _db = new ApplicationDbContext(_dbContext);
            //_db.OrderHeaders.Add(orderHeader);
            //await _db.SaveChangesAsyns();
            return true;
          
        }

        public Task UpdateOrderPaymentStatu(int orderHederId, bool paid)
        {
            //await using var _db = new ApplicationDbContext(_dbContext);


            /**
             var orderHeadrFromDb=await _db.OrderHeders.FirstOrdedaultAsync(x=>x.OrderHederId==orderHederId);
            if(orderHeadrFromDb !=null)
            {
            orderHeadrFromDb.PaymentStatus=paid;
            await _db.SaveChangesAsyns();

            
            }
             
             
             
             
             */
            throw new NotImplementedException();
        }
    }
}
