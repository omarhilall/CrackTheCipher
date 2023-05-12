using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace HamodaDef
{


    public class TextAnim : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _textMeshPro;
        public string[] stringArray;
        [SerializeField] float timeBetweenCharacters;
        [SerializeField] float timeBetweenWords;
        int i = 0;


        void Start()
        {
            EndCheck();
        }

        public void EndCheck()
        {
            if (i <= stringArray.Length - 1)
            {
                _textMeshPro.text = stringArray[i];
                StartCoroutine(TextVisible());
            }
        }


        private IEnumerator TextVisible()
        {
            _textMeshPro.ForceMeshUpdate();
            int visiblechar = _textMeshPro.textInfo.characterCount;
            int counter = 0;

            while (true)
            {
                int visibleCount = counter % (visiblechar + 1);
                _textMeshPro.maxVisibleCharacters = visibleCount;

                if (visibleCount >= visiblechar)
                {
                    i += 1;
                    //Invoke ("EndCheck", timeBetweenWords);
                    break;
                }

                counter += 1;
                yield return new WaitForSeconds(timeBetweenCharacters);
            }
        }
    }
}