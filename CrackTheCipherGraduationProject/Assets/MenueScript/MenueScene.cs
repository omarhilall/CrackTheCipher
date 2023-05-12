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
    }
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
