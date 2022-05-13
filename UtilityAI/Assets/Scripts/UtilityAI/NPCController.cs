using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UAI.Core;


namespace UAI.UtilityAI
{
    public class NPCController : MonoBehaviour
    {
        public MoveController mover { get; set; }
        public AIBrain aiBrain { get; set; }
        public NPCAction[] actionsAvailale;
        // Start is called before the first frame update
        void Start()
        {
            mover = GetComponent<MoveController>();
            aiBrain = GetComponent<AIBrain>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        #region Coroutine
        public void DoWork(int time) {
            StartCoroutine(WorkCoroutine(time));
        }

        IEnumerator WorkCoroutine(int time) {
            int counter = time;
            while (counter > 0)
            {
                yield return new WaitForSeconds(1f);
                counter--;
            }

            Debug.Log("I just harvested 1 resource!");
            //todo: logic for working and spend the energy
        }

        public void DoSleep(int time) {
            StartCoroutine(SleepCoroutine(time));
        }

        IEnumerator SleepCoroutine(int time) {
            int counter = time;
            while (counter > 0)
            {
                yield return new WaitForSeconds(1f);
                counter--;
            }

            Debug.Log("I slept and got 1 energy!");
            //todo: logic for the sleep energy
        }

        #endregion
    }
}


