using System.Collections;

namespace _10_Collections
{
    internal interface IStockRepository
    {
        void SaveStock(Stock yhoo);
        long NextId();
        Stock LoadStock(long id);
        ICollection FindAllStocks();
        void Clear();
    }
}