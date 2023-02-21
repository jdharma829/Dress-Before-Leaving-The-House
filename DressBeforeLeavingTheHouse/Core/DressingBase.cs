using DressBeforeLeavingTheHouse.Enums;
using DressBeforeLeavingTheHouse.Interfaces;
using DressBeforeLeavingTheHouse.Models;

namespace DressBeforeLeavingTheHouse.Core
{
    public abstract class DressingBase : IBottomwear, ILeaveHouse, ITakeOffPajamas, ITopwear
    {
        public List<DressingItem> DressingItems = new();

        public virtual StepStatus Fail() => new StepStatus() { Success = false, Message = "fail" };

        public abstract StepStatus LeaveHouse();

        public abstract StepStatus PutOnFootwear();

        public abstract StepStatus PutOnHeadwear();

        public abstract StepStatus PutOnJacket();

        public abstract StepStatus PutOnPants();

        public virtual StepStatus PutOnShirt()
        {
            if (!DressingItems.Contains(DressingItem.PutOnHeadwear)
                && !DressingItems.Contains(DressingItem.PutOnJacket)
                && DressingItems.Contains(DressingItem.TakeOffPajamas)
                && !DressingItems.Contains(DressingItem.PutOnShirt))
            {
                DressingItems.Add(DressingItem.PutOnShirt);
                return Success("shirt");
            }
            else
                return Fail();
        }

        public abstract StepStatus PutOnSocks();

        public virtual StepStatus Success(string message) => new StepStatus() { Success = true, Message = message };

        public virtual StepStatus TakeOffPajamas()
        {
            if (!DressingItems.Contains(DressingItem.TakeOffPajamas))
            {
                DressingItems.Add(DressingItem.TakeOffPajamas);
                return Success("Removing PJs");
            }
            else { return Fail(); }
        }
    }
}
