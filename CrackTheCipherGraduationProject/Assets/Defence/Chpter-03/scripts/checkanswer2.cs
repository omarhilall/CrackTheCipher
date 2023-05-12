using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class checkanswer2 : MonoBehaviour
{
   public void seektext2(TMP_InputField textfield){
     string text = textfield.GetComponent<TMP_InputField>().text;

     if(text=="we are going through the system")
     {
        Debug.Log("success");
        return ;
     }
   
     Debug.Log("not success");
   }
}
