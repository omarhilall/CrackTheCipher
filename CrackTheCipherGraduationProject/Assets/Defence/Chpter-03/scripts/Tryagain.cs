using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tryagain : MonoBehaviour
{
    public GameObject ButtonSound;
    public void playGame5()
    {
        DontDestroyOnLoad(ButtonSound);
        ButtonSound.SetActive(true);
        SceneManager.LoadScene("scene2");
    }
}