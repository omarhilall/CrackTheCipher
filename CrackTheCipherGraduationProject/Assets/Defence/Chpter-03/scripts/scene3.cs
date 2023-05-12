using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene3 : MonoBehaviour
{
    public GameObject ButtonSound;
    public void playGame2()
    {
        DontDestroyOnLoad(ButtonSound);
        ButtonSound.SetActive(true);
        SceneManager.LoadScene("scene4");
    }
}

