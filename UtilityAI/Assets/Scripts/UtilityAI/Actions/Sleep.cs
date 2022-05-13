using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UAI.Core;


namespace UAI.UtilityAI
{
    [CreateAssetMenu(fileName = "Sleep", menuName = "UtiltiyAI/Actions/Sleep")]
    public class Sleep : NPCAction
    {
        public override void Execute(NPCController npc)
        {
            npc.DoSleep(3);
        }
    }
}
