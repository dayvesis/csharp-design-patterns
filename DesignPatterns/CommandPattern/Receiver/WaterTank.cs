namespace CommandPattern.Receiver
{
    public class WaterTank : IFIllable
    {
        public decimal Capacity { get; set; }
        public decimal CurrentAmount { get; set; }

        public void FIll(decimal amount)
        {
            if (amount < Capacity - CurrentAmount)
                CurrentAmount += amount;
        }

        public void Unfill(decimal amount)
        {
            if (amount < CurrentAmount)
                CurrentAmount -= amount;
        }

        public override string ToString()
        {
            return $"Current watertank status: {CurrentAmount}/{Capacity}";
        }
    }
}
