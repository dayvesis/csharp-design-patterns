using CommandPattern.Receiver;

namespace CommandPattern.Commands
{
    public class FillWaterTankCommand : ICommand
    {
        private readonly WaterTank _waterTank;
        private readonly decimal _amount;

        public FillWaterTankCommand(WaterTank waterTank, decimal amount)
        {
            _waterTank = waterTank;
            _amount = amount;
        }

        public bool CanExecute() => _waterTank.Capacity - _waterTank.CurrentAmount > _amount;

        public void Execute() => _waterTank.FIll(_amount);

        public void Undo() => _waterTank.Unfill(_amount);
    }
}
