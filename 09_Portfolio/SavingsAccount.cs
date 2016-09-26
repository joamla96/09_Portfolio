using System;

namespace _09_Portfolio {
	internal class SavingsAccount : IAsset {
		public string Name { get; set; }
		public double Value { get; set; }
		public double InterestRate { get; internal set; }

		public SavingsAccount(string Name, double Value, double Intrest) {
			this.Name = Name;
			this.Value = Value;
			this.InterestRate = Intrest;
		}

		public double GetValue() {
			return this.Value;
		}

		internal void ApplyInterest() {
			this.Value += this.Value * this.InterestRate / 100;
		}

		public override string ToString() {
			return string.Format("SavingsAccount[value={0:0.0},interestRate={1:0.0}]", this.Value, this.InterestRate);

		}
	}
}