using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;

public enum QuestStatus{Ongoing, Complete, Failed}
public class GameController : MonoBehaviour
{
public QuestNode currentQuest;
public QuestStatus questStatus;
public float questTimer;
[SerializeField] private GameObject failScreen;
[SerializeField] private ScriptMachine player;
[SerializeField] private TMP_Text questText;
[SerializeField] private TMP_Text timerText;
//private QuestNode checkingQuest;
    void Start()
    {
        //checkingQuest = currentQuest;
        questTimer = currentQuest.timer;
        questStatus = QuestStatus.Ongoing;
    }


    void Update()
    {
        if(questTimer <= 0)
        {
            questStatus = QuestStatus.Failed;
        }
        if(questStatus == QuestStatus.Ongoing)
        {
            questTimer -= Time.deltaTime;
            questText.text = currentQuest.questName;
            timerText.text = "Time Left: " + Mathf.RoundToInt(questTimer);
        }
        if(questStatus == QuestStatus.Complete)
        {
            //Debug.Log("I did it");
            questStatus = QuestStatus.Ongoing;
            currentQuest = currentQuest.nextQuest;
            questTimer = currentQuest.timer;
        }
        if(questStatus == QuestStatus.Failed)
        {
            Cursor.lockState = CursorLockMode.None;
            player.enabled = false;
            questText.enabled = false;
            timerText.enabled = false;
            failScreen.SetActive(true);
        }
        /*if(checkingQuest != currentQuest)
        {
            Debug.Log("It changed");
        }*/
    }
}
