using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{
    public void PlayDemo()
 {
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
 }
 public void PlayGame()
 {
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); 
 }
 public void BackMain()
 {
  SceneManager.LoadScene(0); 
 }

 public void exit()
 {
    Application.Quit();
    Debug.Log("Quit");
 }
}
