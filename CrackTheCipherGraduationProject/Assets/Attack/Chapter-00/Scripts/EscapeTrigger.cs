using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeTrigger : MonoBehaviour
{
    [SerializeField] private string tagToDetect = "Player";


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagToDetect))
        {
            if (UIManager.instance != null)
            {
                if (UIManager.instance.canEscape)
                {
                    UIManager.instance.gameState = GameState.GameWin;
                    Time.timeScale = 0;
                    UIManager.instance.winPanel.SetActive(true);
                }
            }
        }
    }

}
