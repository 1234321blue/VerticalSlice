using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
public QuestNode currentQuest;
//private QuestNode checkingQuest;
    void Start()
    {
        //checkingQuest = currentQuest;
    }


    void Update()
    {
        if(currentQuest.completion == QuestStatus.Complete)
        {
            //Debug.Log("I did it");
            currentQuest = currentQuest.nextQuest;
        }
        /*if(checkingQuest != currentQuest)
        {
            Debug.Log("It changed");
        }*/
    }
}
