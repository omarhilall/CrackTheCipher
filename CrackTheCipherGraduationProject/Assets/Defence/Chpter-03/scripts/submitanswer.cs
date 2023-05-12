using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class submitanswer : MonoBehaviour
{
    public TMP_InputField AnswerField;
    public TMP_InputField AnswerField2;

    public string Answer;
    public string Answer2;

    public GameObject ButtonSound;
    public GameObject ErrorSound;
    public void Back()
    {
        DontDestroyOnLoad(ButtonSound);
        ButtonSound.SetActive(true);
        SceneManager.LoadScene("scene4");
    }
    public void playGame9()
    {
        if(AnswerField.text == Answer && AnswerField2.text == Answer2)
        {
            DontDestroyOnLoad(ButtonSound);
            ButtonSound.SetActive(true);
            SceneManager.LoadScene("scene7");
        }
        else 
        {
            DontDestroyOnLoad(ErrorSound);
            ErrorSound.SetActive(true);
            SceneManager.LoadScene("Try Again");
        }
        }
        
}