using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;




public class SlideButton1 : MonoBehaviour
{

    //public AudioSource wrong;
    //public AudioSource correct;
    public void checkText(TMP_InputField textfield){
        
        string text = textfield.GetComponent<TMP_InputField>().text;
        if(text=="there is a spy"){
            Debug.Log("Success");
            //PlayCorrect();
     
            return;
        }
        Debug.Log(text);
        //PlayWrong();

    }

   /* public void PlayWrong(){
        wrong.Play;
    }

    public void PlayCorrect(){
        correct.Play;
    }
    */
}
