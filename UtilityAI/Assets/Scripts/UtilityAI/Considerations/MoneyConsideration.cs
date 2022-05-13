using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UAI.UtilityAI.Considerations
{
    [CreateAssetMenu(fileName = "MoneyConsideration", menuName = "UtiltiyAI/Consideration/MoneyConsideration")]
    public class MoneyConsideration : Consideration
    {
        public override float ScoreConsideration()
        {
            return 0.9f;
        }
    }
}