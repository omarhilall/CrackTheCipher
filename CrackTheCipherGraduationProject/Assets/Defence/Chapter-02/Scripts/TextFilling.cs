using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace ZakyDeffence
{
    public class TextFilling : MonoBehaviour
    {
        float typingSpeed = 0.1f;
        TMP_Text meassageText;
        [SerializeField]
        string fullText;
        string currentText = "";

        private void Start()
        {
            meassageText = GetComponent<TMP_Text>();
            meassageText.text = "";
            StartCoroutine(TypeText());
        }

        private IEnumerator TypeText()
        {
            for (int i = 0; i < fullText.Length; i++)
            {
                currentText += fullText[i];
                meassageText.text = currentText;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
    }
}