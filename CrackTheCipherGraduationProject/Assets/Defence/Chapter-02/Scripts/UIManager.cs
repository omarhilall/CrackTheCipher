using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;


namespace ZakyDeffence
{
    public class UIManager : MonoBehaviour
    {
        int pageIndex = 1;
        [SerializeField]
        GameObject[] Pages;
        [SerializeField]
        GameObject passwordFieldpanel, clearBtnobject, checkBtnobject, congratsImage;

        int passIndex = 0;
        [SerializeField]
        Button clearBtn, checkBtn, nameDoneBtn;
        [SerializeField]
        TMP_Text nameText;
        string totalInputWord;
        [SerializeField]
        TMP_Text[] passText;
        //[SerializeField]
        //string[] wrongWords;
        string userName;
        private void Start()
        {
            clearBtn.onClick.AddListener(clear);
            checkBtn.onClick.AddListener(SwitchPages);
            nameDoneBtn.onClick.AddListener(NameEntered);
        }
        private void LateUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                if (passIndex > 0)
                {
                    passIndex -= 1;
                    passText[passIndex].text = "";
                    totalInputWord = totalInputWord.Substring(0, totalInputWord.Length - 1);
                }
            }
            else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.LeftShift) && !Input.GetKeyDown(KeyCode.RightShift))
            {
                SetInputPassword(Input.inputString);
            }
        }
        void SwitchPages()
        {
            switch (pageIndex)
            {
                case 2:
                    if (totalInputWord == "PASSWORD" && totalInputWord != userName)
                    {
                        Pages[1].SetActive(false);
                        Pages[2].SetActive(true);
                        pageIndex += 1;
                    }
                    break;
                case 3:
                    if (ContainsOnlyCharacters(totalInputWord) && totalInputWord.Length > 7 && totalInputWord != userName && totalInputWord != "PASSWORD")
                    {
                        Pages[2].SetActive(false);
                        Pages[3].SetActive(true);
                        pageIndex += 1;
                    }
                    break;
                case 4:
                    if (ContainsCharacters(totalInputWord) && ContainsNumbers(totalInputWord) && !ContainsSymbols(totalInputWord) && totalInputWord.Length > 9 && totalInputWord != userName && totalInputWord != "PASSWORD")
                    {
                        Pages[3].SetActive(false);
                        Pages[4].SetActive(true);
                        pageIndex += 1;
                    }
                    break;
                case 5:
                    Debug.Log("five");
                    if (ContainsCharacters(totalInputWord) && ContainsNumbers(totalInputWord) && ContainsSymbols(totalInputWord) && totalInputWord.Length > 9 && totalInputWord != userName && totalInputWord != "PASSWORD")
                    {
                        Debug.Log("five done");

                        Pages[4].SetActive(false);
                        passwordFieldpanel.SetActive(false);
                        congratsImage.SetActive(true);
                        clearBtnobject.SetActive(false);
                        nameText.gameObject.SetActive(false);
                        checkBtn.gameObject.SetActive(false);
                        pageIndex += 1;
                    }
                    break;
            }
        }
        void SetInputPassword(string pass)
        {
            if (passIndex < 13 && pass.Length == 1)
            {
                passText[passIndex].text = pass;
                passIndex += 1;
                //this is the password of the user
                totalInputWord += pass;
            }
        }
        void clear()
        {
            foreach (TMP_Text text in passText)
            {
                text.text = "";
            }
            totalInputWord = "";
            passIndex = 0;
        }
        void NameEntered()
        {
            pageIndex += 1;
            Pages[0].SetActive(false);
            Pages[1].SetActive(true);
            userName = totalInputWord;
            nameText.text = " Welcome: " + userName;
            nameDoneBtn.gameObject.SetActive(false);
            passwordFieldpanel.SetActive(true);
            checkBtnobject.SetActive(true);
            clearBtnobject.SetActive(true);
            clear();
        }
        bool ContainsOnlyCharacters(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        bool ContainsCharacters(string input)
        {
            foreach (char c in input)
            {
                if (Char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }
        bool ContainsNumbers(string input)
        {
            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        bool ContainsSymbols(string inputString)
        {
            foreach (char c in inputString)
            {
                if (c == '!' || c == '@' || c == '#' || c == '$' || c == '%' || c == '^' || c == '&' || c == '*')
                {
                    return true;
                }
            }
            return false;
        }
        //void CheckWrongWords()
        //{
        //    foreach(string name in wrongWords)
        //    {
        //        if (totalInputWord == name)
        //        {
        //            wrongWordDetected = true;
        //        }
        //        else
        //        {
        //            wrongWordDetected = false;
        //        }
        //    }
        //}

        public void LoadMenue() // maged
        {
            SceneManager.LoadScene("Menue");
        }
    }
}