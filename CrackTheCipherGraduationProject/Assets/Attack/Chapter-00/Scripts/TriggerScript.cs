using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerScript : MonoBehaviour
{

    [SerializeField] private string tagToDetect = "Player";
    [Space]
    [SerializeField] private UnityEvent triggerEnterEvent;
    [Space]
    [SerializeField] private UnityEvent triggerExitEvent;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagToDetect))
        {
            triggerEnterEvent.Invoke();

            if (UIManager.instance != null)
            {
                UIManager.instance.SetMsgText("Press F to take down guard.");
                UIManager.instance.gameState = GameState.TakeDownEnemy;
                UIManager.instance.currentGuard = transform.parent.gameObject;
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagToDetect))
        {
            triggerExitEvent.Invoke();

            if (UIManager.instance != null)
            {
                UIManager.instance.SetMsgText(string.Empty);
                UIManager.instance.gameState = GameState.None;
                UIManager.instance.currentGuard = null;
            }
        }
    }


}
