using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DZakyTrigger : MonoBehaviour
{
    bool enterSceen = false;

    // Update is called once per frame
    void Update()
    {
        if (enterSceen && Input.GetKeyDown(KeyCode.F))

        {

            SceneManager.LoadScene("ZakyDefence");
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
