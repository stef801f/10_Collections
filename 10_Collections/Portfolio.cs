using System;
using System.Collections.Generic;

namespace _10_Collections
{
	internal class Portfolio : IAsset {
			private List<IAsset> stocks;

		public Portfolio(List<IAsset> stocks) {
			this.stocks = stocks;
		}

		public Portfolio() {
			stocks = new List<IAsset>();
		}

		public double GetTotalValue() {
			double Sum = 0;

			foreach(IAsset stock in stocks) {
				Sum += stock.GetValue();
			}

			return Sum;
		}

		public void AddAsset(IAsset Stock) {
			this.stocks.Add(Stock);
		}

		public double GetValue() {
			throw new NotImplementedException();
		}

        internal IAsset GetAssetByName(string name)
        {
            IAsset element = null;
            foreach (IAsset stock in stocks) {
            if (stock.GetName().Equals(name))
                {
                    element = stock;
                }
            }
            return element;
        }

        internal IList<IAsset> GetAssetsSortedByName()
        {
            stocks.Sort(new StockNameComparator());
            return stocks;
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            stocks.Sort(new StockValueComparator());
            return stocks;
        }

        internal IList<IAsset> GetAssets()
        {
            return  stocks.AsReadOnly();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}