using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using System;

public class MGamePuzzel : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;
    [SerializeField] Door door;
   // [SerializeField] int SecretNumber;
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    [SerializeField] TextMeshProUGUI PasswordTextUi;
    [SerializeField] string passwordtext;
    [SerializeField] string passwordnumber;
    bool IStrue = false;
    // Start is called before the first frame update
    void Start()
    {
        GenerateWord();
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GenerateWord()
    {
        for (int i = 0; i < 4; i++)
        {
            int x =  UnityEngine.Random.Range(1, 27);
            passwordnumber += x.ToString();
            passwordtext += chars[x-1];
        }
        PasswordTextUi.text = passwordtext;
    }
   

    public void CheckIFPasswordISPassword()
    {
        if (IStrue) return;
        int userinput;
        int passNum;
        int.TryParse(passwordnumber, out passNum);
        int.TryParse(inputField.text,out userinput);
        
        if (userinput == passNum)
        {
            door.OpenTheDoor();
            UIManager.instance.ShowObjective(3);
            IStrue = true;
        }
    }
}
