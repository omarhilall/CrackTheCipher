using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene5 : MonoBehaviour
{
    public GameObject ButtonSound;
    public void playGame8()
    {
        DontDestroyOnLoad(ButtonSound);
        ButtonSound.SetActive(true);
        SceneManager.LoadScene("scene8");
    }
}
