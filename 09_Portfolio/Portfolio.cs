using System;
using System.Collections.Generic;

namespace _09_Portfolio {
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
	}
}