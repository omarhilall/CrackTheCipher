using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheckAnswer : MonoBehaviour
{
   public void seektext(TMP_InputField textfield){
     string text = textfield.GetComponent<TMP_InputField>().text;

     if(text=="abdelrahman")
     {
        Debug.Log("success");
        return ;
     }
   
     Debug.Log("not success");
   }
}
