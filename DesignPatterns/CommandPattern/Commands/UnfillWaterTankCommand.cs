using CommandPattern.Receiver;

namespace CommandPattern.Commands
{
    public class UnfillWaterTankCommand : ICommand
    {
        private readonly WaterTank _waterTank;
        private readonly decimal _amount;

        public UnfillWaterTankCommand(WaterTank waterTank, decimal amount)
        {
            _waterTank = waterTank;
            _amount = amount;
        }

        public bool CanExecute() => _waterTank.CurrentAmount > _amount;

        public void Execute() => _waterTank.Unfill(_amount);

        public void Undo() => _waterTank.FIll(_amount);
    }
}
