using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace ZakyDeffence
{
    public class Hovering : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        Color btnColor;
        Button letterBtn;
        private void Start()
        {
            letterBtn = GetComponent<Button>();
            btnColor = letterBtn.image.color;
        }
        public void OnPointerEnter(PointerEventData eventData)
        {
            letterBtn.image.color = Color.yellow;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            letterBtn.image.color = btnColor;
        }
    }
}