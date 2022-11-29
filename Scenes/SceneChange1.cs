using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1 : MonoBehaviour
{
    public void ChangeScene1()
    {
        SceneManager.LoadScene("Scene3");
    }
}
