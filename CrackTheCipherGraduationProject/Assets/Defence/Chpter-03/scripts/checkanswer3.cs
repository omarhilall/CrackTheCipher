using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class checkanswer3 : MonoBehaviour
{
   public void seektext3(TMP_InputField textfield){
     string text = textfield.GetComponent<TMP_InputField>().text;

     if(text=="iio arin ktyi oirimg rwfc")
     {
        Debug.Log("success");
        return ;
     }
   
     Debug.Log("not success");
   }
}
