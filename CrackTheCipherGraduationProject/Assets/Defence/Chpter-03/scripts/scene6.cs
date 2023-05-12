using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene6 : MonoBehaviour
{
    public GameObject ButtonSound;
    public void PlayGame6()
    {
        DontDestroyOnLoad(ButtonSound);
        ButtonSound.SetActive(true);
        SceneManager.LoadScene("scene4");
    }
}