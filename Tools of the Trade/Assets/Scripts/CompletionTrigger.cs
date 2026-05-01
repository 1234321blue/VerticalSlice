using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletionTrigger : MonoBehaviour
{
    [SerializeField] private GameController gameController;
    private bool goalReached = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !goalReached)
        {
            gameController.questStatus = QuestStatus.Complete;
            goalReached = true;
        }
    }
}
