using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SlideButton3 : MonoBehaviour
{
    public void checkText(TMP_InputField textfield){
        
        string text = textfield.GetComponent<TMP_InputField>().text;
        if(text=="atpajwwsg"){
            Debug.Log("Success");

            return;
        }
        Debug.Log(text);



    }
}
