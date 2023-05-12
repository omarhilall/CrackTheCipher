using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wrongAnswer : MonoBehaviour
{
    public GameObject ErrorSound;
    public void playGame4()
    {
        DontDestroyOnLoad(ErrorSound);
        ErrorSound.SetActive(true);
        SceneManager.LoadScene("scene5");
    }
}