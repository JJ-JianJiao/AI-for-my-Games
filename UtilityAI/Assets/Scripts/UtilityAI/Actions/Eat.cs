using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UAI.Core;

namespace UAI.UtilityAI
{
    [CreateAssetMenu(fileName = "Eat", menuName = "UtiltiyAI/Actions/Eat")]
    public class Eat : NPCAction
    {
        public override void Execute(NPCController npc)
        {
            Debug.Log("I ate food and I am not hungry!");
            //TODO: logic for eating
        }
    }
}
