using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HamodaTrigger : MonoBehaviour
{
    bool enterSceen = false;

    // Update is called once per frame
    void Update()
    {
        if (enterSceen && Input.GetKeyDown(KeyCode.F))

        {
            SceneManager.LoadScene("HamodaAttack");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        enterSceen = true;

        UIManager.instance.SetMsgText("Press F to start the chapter .");
    }

    private void OnTriggerExit(Collider other)
    {
        enterSceen = false;
        UIManager.instance.SetMsgText("");

    }
}
