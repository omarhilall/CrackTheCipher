using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour
{
  public void playGame()
    {
        SceneManager.LoadScene("scene2");
    }
   
}