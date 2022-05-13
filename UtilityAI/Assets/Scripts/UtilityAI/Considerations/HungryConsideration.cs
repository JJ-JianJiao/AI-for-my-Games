using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UAI.UtilityAI.Considerations
{
    [CreateAssetMenu(fileName = "HungryConsideration", menuName = "UtiltiyAI/Consideration/HungryConsideration")]
    public class HungryConsideration : Consideration
    {
        public override float ScoreConsideration()
        {
            return 0.2f;
        }
    }
}
