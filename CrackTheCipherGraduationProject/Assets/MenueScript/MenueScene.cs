using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenueScene : MonoBehaviour
{
   public void LoadCHapterZeroAttack()
    {
        SceneManager.LoadScene("AttackChapterZero");
    }
    public void LoadCHapterOneAttack()
    {
          SceneManager.LoadScene("AttackChapterOne");
       // StartCoroutine(LoadYourAsyncScene());
    }
    //IEnumerator LoadYourAsyncScene()
    //{
    //    // The Application loads the Scene in the background as the current Scene runs.
    //    // This is particularly good for creating loading screens.
    //    // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
    //    // a sceneBuildIndex of 1 as shown in Build Settings.

    //    AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("AttackChapterOne");

    //    // Wait until the asynchronous scene fully loads
    //    while (!asyncLoad.isDone)
    //    {
    //        yield return null;
    //    }
    //}
        public void LoadCHapterTwoAttack()
    {
        SceneManager.LoadScene("AttackChapterTwo");
    }
    public void LoadCHapterThreeAttack()
    {
        SceneManager.LoadScene("AttackChapterThree");
    }
    public void LoadCHapterFourAttack()
    {
        SceneManager.LoadScene("AttackChapterFour");
    }


    public void LoadCHapterOneDefence()
    {
        SceneManager.LoadScene("DefenceChapterOne");
    }
    public void LoadCHapterTwoDefence()
    {
        SceneManager.LoadScene("DefenceChapterTwo");
    }
    public void LoadCHapterThreeDefence()
    {
        SceneManager.LoadScene("DefenceChapterThree");
    }
    public void LoadMenue()
    {
        SceneManager.LoadScene("Menue");
    }
    public void LoadExit()
    {
        Application.Quit();
       
    }
}
