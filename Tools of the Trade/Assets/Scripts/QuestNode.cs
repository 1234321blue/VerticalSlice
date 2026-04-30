using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public enum QuestStatus{Ongoing, Complete, Failed}

[CreateAssetMenu(fileName = "QuestNode", menuName = "ScriptableObjects/QuestNode", order = 1)]
public class QuestNode : ScriptableObject
{
    public float timer;

    public string questName;

    public QuestStatus completion;
    
    public QuestNode nextQuest;
}
