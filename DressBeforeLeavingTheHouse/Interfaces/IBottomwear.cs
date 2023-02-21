using DressBeforeLeavingTheHouse.Models;

namespace DressBeforeLeavingTheHouse.Interfaces
{
    public interface IBottomwear
    {
        StepStatus PutOnFootwear();
        StepStatus PutOnPants();
        StepStatus PutOnSocks();
    }
}
