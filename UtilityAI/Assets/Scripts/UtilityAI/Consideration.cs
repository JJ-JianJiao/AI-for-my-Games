using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace UAI.UtilityAI
{
    public abstract class Consideration : ScriptableObject
    {
        public string conName;
        private float _score;

        public float Score
        {
            get { return _score; }
            set { _score = Mathf.Clamp01(value); }
        }

        public virtual void Awake() {
            _score = 0;
        }

        public abstract float ScoreConsideration();
            
    }
}
