using DressBeforeLeavingTheHouse.Enums;
using DressBeforeLeavingTheHouse.Models;

namespace DressBeforeLeavingTheHouse.Core
{
    public class ColdDressingStyle : DressingBase
    {
        public override StepStatus LeaveHouse()
        {
            if (DressingItems.Contains(DressingItem.PutOnFootwear)
                && DressingItems.Contains(DressingItem.PutOnHeadwear)
                && DressingItems.Contains(DressingItem.PutOnSocks)
                && DressingItems.Contains(DressingItem.PutOnShirt)
                && DressingItems.Contains(DressingItem.PutOnJacket)
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
            if (DressingItems.Contains(DressingItem.PutOnSocks)
                && DressingItems.Contains(DressingItem.TakeOffPajamas)
                && !DressingItems.Contains(DressingItem.PutOnFootwear))
            {
                DressingItems.Add(DressingItem.PutOnFootwear);
                return Success("boots");
            }
            else { return Fail(); }
        }

        public override StepStatus PutOnHeadwear()
        {
            if (DressingItems.Contains(DressingItem.TakeOffPajamas)
                && !DressingItems.Contains(DressingItem.PutOnHeadwear))
            {
                DressingItems.Add(DressingItem.PutOnHeadwear);
                return Success("hat");
            }
            else { return Fail(); }
        }

        public override StepStatus PutOnJacket()
        {
            if (DressingItems.Contains(DressingItem.TakeOffPajamas)
               && !DressingItems.Contains(DressingItem.PutOnJacket))
            {
                DressingItems.Add(DressingItem.PutOnJacket);
                return Success("jacket");
            }
            else { return Fail(); }
        }

        public override StepStatus PutOnPants()
        {
            if (!DressingItems.Contains(DressingItem.PutOnFootwear)
                && DressingItems.Contains(DressingItem.TakeOffPajamas)
                && !DressingItems.Contains(DressingItem.PutOnPants))
            {
                DressingItems.Add(DressingItem.PutOnPants);
                return Success("pants");
            }
            else { return Fail(); }
        }

        public override StepStatus PutOnSocks()
        {
            if (DressingItems.Contains(DressingItem.TakeOffPajamas)
                && !DressingItems.Contains(DressingItem.PutOnSocks))
            {
                DressingItems.Add(DressingItem.PutOnSocks);
                return Success("socks");
            }
            else { return Fail(); }
        }
    }
}
