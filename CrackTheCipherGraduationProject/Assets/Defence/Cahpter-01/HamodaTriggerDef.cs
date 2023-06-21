using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HamodaTriggerDef : MonoBehaviour
{
    bool enterSceen = false;
    void Update()
    {
        if (enterSceen && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("RansomwareDefence");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        enterSceen = false;
        UIManager.instance.SetMsgText("");

    }
    private void OnTriggerEnter(Collider other)
    {
        enterSceen = true;
        UIManager.instance.SetMsgText("Press F to start the chapter .");
    }
}
