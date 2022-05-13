using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UAI.UtilityAI.Considerations
{
    [CreateAssetMenu(fileName = "EnergyConsideration", menuName = "UtiltiyAI/Consideration/EnergyConsideration")]
    public class EnergyConsideration : Consideration
    {
        public override float ScoreConsideration()
        {
            return 0.1f;
        }
    }
}
