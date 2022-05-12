using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UtilityAI_Core
{

    public class AIBrain : MonoBehaviour
    {

        public NPCAction bestAction { get; set; }
        private NPCController npc;

        // Start is called before the first frame update
        void Start()
        {
            npc = GetComponent<NPCController>();
        }

        // Update is called once per frame
        void Update()
        {

        }



        //using the loop for all the considerations of the action and score all the considerations
        //calculate the consideration scores and get the overall action score
        public float ScoreAction(NPCAction action) {
            float score = 1f;
            for (int i = 0; i < action.considerations.Length; i++)
            {
                float considerationsScore = action.considerations[i].ScoreConsideration();
                score *= considerationsScore;

                if (score == 0) {   //no urgent consideration
                    return action.Score = 0;
                }
            }


            //TODO: this Math method need to figure out
            //Averaging scheme of overall score
            float originalScore = score;
            float modFactor = 1 - (1 / action.considerations.Length); //modification factor
            float makeupValue = (1 - originalScore) * modFactor;
            action.Score = originalScore + (makeupValue * originalScore);


            return action.Score;
        }

        //use loop to go through all the actions and calculate the highest score action
        public void DecideBestAction(NPCAction[] actionsAvailable) {
            float score = 0f;
            int nextBestActionIndex = 0;
            for (int i = 0; i < actionsAvailable.Length; i++)
            {
                if (ScoreAction(actionsAvailable[i]) > score) {
                    nextBestActionIndex = i;
                    score = actionsAvailable[i].Score;
                }
            }

            bestAction = actionsAvailable[nextBestActionIndex];
        }
    }
}
