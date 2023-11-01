using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.PubSub.Models
{
    public class HypeTrainConductorRewards
    {
        public HypeTrainConductorReward[] BitsCurrent;
        public HypeTrainConductorReward[] BitsFormer;
        public HypeTrainConductorReward[] PurchaseCurrent;
        public HypeTrainConductorReward[] PurchaseFormer;
        public HypeTrainConductorReward[] SubsCurrent;
        public HypeTrainConductorReward[] SubsFormer;
    }
}
