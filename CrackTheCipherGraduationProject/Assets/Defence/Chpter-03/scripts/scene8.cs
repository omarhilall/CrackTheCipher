using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class scene8 : MonoBehaviour
{
    public TMP_InputField AnswerField;

    public string Answer;

    public GameObject ButtonSound;
    public GameObject ErrorSound;
    public void endGame()
    {
        if (AnswerField.text == Answer)
        {
            DontDestroyOnLoad(ButtonSound);
            ButtonSound.SetActive(true);
            SceneManager.LoadScene("scene9");
        }
        else
        {
            DontDestroyOnLoad(ErrorSound);
            ErrorSound.SetActive(true);
            SceneManager.LoadScene("Try Again2");
        }
    }
}