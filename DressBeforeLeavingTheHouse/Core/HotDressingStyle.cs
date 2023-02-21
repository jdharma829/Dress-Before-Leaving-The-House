using DressBeforeLeavingTheHouse.Enums;
using DressBeforeLeavingTheHouse.Models;

namespace DressBeforeLeavingTheHouse.Core
{
    public class HotDressingStyle : DressingBase
    {
        public override StepStatus LeaveHouse()
        {
            if (DressingItems.Contains(DressingItem.PutOnFootwear)
                && DressingItems.Contains(DressingItem.PutOnHeadwear)
                && DressingItems.Contains(DressingItem.PutOnShirt)
                && DressingItems.Contains(DressingItem.PutOnPants)
                && DressingItems.Contains(DressingItem.TakeOffPajamas)
                && !DressingItems.Contains(DressingItem.LeaveHouse))
            {
                DressingItems.Add(DressingItem.LeaveHouse);
                return Success("leaving house");
            }
            else { return Fail(); }
        }

        public override StepStatus PutOnFootwear()
        {
            if (DressingItems.Contains(DressingItem.TakeOffPajamas)
                && !DressingItems.Contains(DressingItem.PutOnFootwear))
            {
                DressingItems.Add(DressingItem.PutOnFootwear);
                return Success("sandals");
            }
            else
                return Fail();
        }

        public override StepStatus PutOnHeadwear()
        {
            if (DressingItems.Contains(DressingItem.TakeOffPajamas)
                && !DressingItems.Contains(DressingItem.PutOnHeadwear))
            {
                DressingItems.Add(DressingItem.PutOnHeadwear);
                return Success("sunglasses");
            }
            else { return Fail(); }
        }

        public override StepStatus PutOnJacket() => Fail();

        public override StepStatus PutOnPants()
        {
            if (!DressingItems.Contains(DressingItem.PutOnFootwear)
                && DressingItems.Contains(DressingItem.TakeOffPajamas)
                && !DressingItems.Contains(DressingItem.PutOnPants))
            {
                DressingItems.Add(DressingItem.PutOnPants);
                return Success("shorts");
            }
            else { return Fail(); }
        }

        public override StepStatus PutOnSocks() => Fail();
    }
}
