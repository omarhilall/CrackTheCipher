using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackComputerTrigger : MonoBehaviour
{
    [SerializeField] private bool takeOutElectricity;
    [SerializeField] private bool changeClothes;
    [SerializeField] private GameObject elactricTrigger;
    public GameObject winTrigger;


    [SerializeField] private string tagToDetect = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagToDetect))
        {
            if (UIManager.instance != null)
            {
                UIManager.instance.currentGuard = this.gameObject;

                if (changeClothes)
                {
                    UIManager.instance.SetMsgText("Press F To Change Clothes.");
                    UIManager.instance.gameState = GameState.ChangeClothes;
                }
                else if (takeOutElectricity)
                {
                    UIManager.instance.SetMsgText("Press F To Hack To Get The Passcode.");
                    UIManager.instance.gameState = GameState.TakeOutPower;
                 
                }
                else
                {
                    UIManager.instance.gameState = GameState.Hack;
                    UIManager.instance.TogglePopUp(true);
                    elactricTrigger.SetActive(false);
                    winTrigger.SetActive(true);
                }
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(tagToDetect))
        {
            if (UIManager.instance != null)
            {
                UIManager.instance.currentGuard = null;
               
                if (takeOutElectricity)
                {
                    UIManager.instance.SetMsgText("");
                    UIManager.instance.gameState = GameState.None;
                  
                }
                else
                {
                    UIManager.instance.SetMsgText("");
                    UIManager.instance.gameState = GameState.None;
                    UIManager.instance.TogglePopUp(false);
                }
            }
        }
    }

}
