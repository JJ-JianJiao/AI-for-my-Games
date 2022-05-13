using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UAI.UtilityAI;

namespace UAI.Core{

    public abstract class NPCAction : ScriptableObject
    {
        public string actionName;
        private float _score;

        public float Score {
            get { return _score; }
            set { _score = Mathf.Clamp01(value); }
        }

        public Consideration[] considerations;

        public virtual void Awake() {
            _score = 0;
        }

        public abstract void Execute(NPCController npc);


    }
}