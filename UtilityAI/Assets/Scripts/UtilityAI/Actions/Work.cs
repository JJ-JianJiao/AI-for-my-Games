using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UAI.Core;



namespace UAI.UtilityAI
{
    [CreateAssetMenu(fileName ="Work", menuName ="UtiltiyAI/Actions/Work")]
    public class Work : NPCAction
    {
        public override void Execute(NPCController npc)
        {
            npc.DoWork(3);
        }

    }

}