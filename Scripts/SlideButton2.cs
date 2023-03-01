using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlideButton2 : MonoBehaviour
{
    public void checkText(TMP_InputField textfield){
        
        string text = textfield.GetComponent<TMP_InputField>().text;

        if(text=="save the embassy"){
            Debug.Log("Success");

            return;
        }
        Debug.Log(text);



    }
}
