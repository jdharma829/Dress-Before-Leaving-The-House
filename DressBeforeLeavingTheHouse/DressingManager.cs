using DressBeforeLeavingTheHouse.Core;
using DressBeforeLeavingTheHouse.Enums;
using DressBeforeLeavingTheHouse.Models;

namespace DressBeforeLeavingTheHouse
{
    public class DressingManager
    {
        private readonly string _failMessage = "fail";

        public string Process(string input)
        {
            string result = string.Empty;
            try
            {
                List<string> parts = input.Split(' ').ToList();

                if (parts.Count > 1 && Enum.TryParse(parts[0].Trim(), out WeatherCondition condition))
                {
                    DressingBase? obj = null;
                    if (condition == WeatherCondition.HOT)
                        obj = new HotDressingStyle();
                    else if (condition == WeatherCondition.COLD)
                        obj = new ColdDressingStyle();

                    if (obj != null)
                    {
                        StepStatus status = new StepStatus() { Success = true, Message = string.Empty };
                        for (int iIndex = 1; iIndex < parts.Count; iIndex++)
                        {
                            if (status.Success && Enum.TryParse(parts[iIndex].Trim(',').Trim(), out DressingItem item))
                            {
                                status = item switch
                                {
                                    DressingItem.PutOnFootwear => obj.PutOnFootwear(),
                                    DressingItem.PutOnHeadwear => obj.PutOnHeadwear(),
                                    DressingItem.PutOnSocks => obj.PutOnSocks(),
                                    DressingItem.PutOnShirt => obj.PutOnShirt(),
                                    DressingItem.PutOnJacket => obj.PutOnJacket(),
                                    DressingItem.PutOnPants => obj.PutOnPants(),
                                    DressingItem.LeaveHouse => obj.LeaveHouse(),
                                    DressingItem.TakeOffPajamas => obj.TakeOffPajamas(),
                                    _ => obj.Fail(),
                                };
                                result = AppendResult(result, status.Message);
                                if (!status.Success) break;

                                if (iIndex == parts.Count - 1 && item != DressingItem.LeaveHouse)
                                    result = AppendResult(result, _failMessage);
                            }
                            else
                            {
                                result = AppendResult(result, _failMessage);
                                break;
                            }
                        }
                    }
                    else
                        result = AppendResult(result, _failMessage);

                }
                else
                    result = AppendResult(result, _failMessage);
            }
            catch
            {
                result = AppendResult(result, _failMessage);
            }

            return result;
        }

        private string AppendResult(string result, string message)
        {
            if (string.IsNullOrEmpty(result))
                result = message;
            else
                result += $", {message}";
            return result;
        }
    }
}
