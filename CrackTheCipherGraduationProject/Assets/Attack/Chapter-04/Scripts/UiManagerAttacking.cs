using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


namespace ZakyAttack
{
    public class UiManagerAttacking : MonoBehaviour
    {
        int passIndex = 0;
        int attemptCount = 0;
        string Password = "security";
        [SerializeField]
        GameObject[] attemptionBlocks;
        [SerializeField]
        Button clearBtn, checkBtn, playAgainbtnwin, playAgainbtnlose;
        [SerializeField]
        TMP_Text[] passText;
        TMP_Text[] attemptionBlocksTexts;
        string totalPassword;
        [SerializeField]
        GameObject hidePanel, winPanel, losePanel, attemptionBlockspanel;
        private void Start()
        {
            clearBtn.onClick.AddListener(clear);
            checkBtn.onClick.AddListener(Check);
            playAgainbtnwin.onClick.AddListener(PlayAgain);
            playAgainbtnlose.onClick.AddListener(PlayAgain);
        }
        private void LateUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                if (passIndex > 0)
                {
                    passIndex -= 1;
                    passText[passIndex].text = "";
                    totalPassword = totalPassword.Substring(0, totalPassword.Length - 1);
                }
            }
            else if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.LeftShift) && !Input.GetKeyDown(KeyCode.RightShift))
            {
                SetInputPassword(Input.inputString);
            }
        }
        void SetInputPassword(string pass)
        {
            if (passIndex < 8 && pass.Length == 1)
            {
                passText[passIndex].text = pass;
                passIndex += 1;
                //this is the password of the user
                totalPassword += pass;
            }
        }
        public void clear()
        {
            foreach (TMP_Text text in passText)
            {
                text.text = "";
            }
            totalPassword = "";
            passIndex = 0;
        }
        void Check()
        {
            if (totalPassword.Length == 8)
            {
                attemptionBlocks[attemptCount].SetActive(true);
                attemptionBlocksTexts = attemptionBlocks[attemptCount].GetComponentsInChildren<TMP_Text>();
                for (int i = 0; i < totalPassword.Length; i++)
                {
                    attemptionBlocksTexts[i].text = totalPassword[i].ToString();
                    if (totalPassword[i] == Password[i])
                    {
                        //letter is right and in the right position
                        attemptionBlocksTexts[i].transform.parent.GetComponent<Image>().color = Color.green;
                    }
                    else if (Password.Contains(totalPassword[i]))
                    {
                        //letter is right but in the wrong position
                        attemptionBlocksTexts[i].transform.parent.GetComponent<Image>().color = Color.yellow;
                    }
                }
                attemptCount += 1;
                if (totalPassword == Password)
                {
                    //Succeeded to guess the word
                    winPanel.SetActive(true);
                    hidePanel.SetActive(true);
                    attemptionBlockspanel.SetActive(false);
                }
                else if (totalPassword != Password && attemptCount == 7)
                {
                    //Failed to guess the word
                    losePanel.SetActive(true);
                    hidePanel.SetActive(true);
                    attemptionBlockspanel.SetActive(false);
                }
                clear();
            }
        }
        void PlayAgain()
        {
            //reset game data
            hidePanel.SetActive(false);
            winPanel.SetActive(false);
            losePanel.SetActive(false);
            attemptionBlockspanel.SetActive(true);
            foreach (GameObject attemp in attemptionBlocks)
            {
                attemp.SetActive(false);
                Image[] allBlockimages = attemp.GetComponentsInChildren<Image>();
                foreach (Image blockimage in allBlockimages)
                {
                    blockimage.color = Color.white;
                }
            }

            attemptCount = 0;
        }
        //private void Start()
        //{
        //    for (int i = 0; i < 26; i++)
        //    {
        //        string t = inputBtns[i].transform.GetChild(0).GetComponent<TMP_Text>().text;
        //        inputBtns[i].onClick.AddListener(delegate { SetInputPassword(t); });
        //    }
        //    clearBtn.onClick.AddListener(clear);
        //}

        public void LoadMenue() // maged
        {
            SceneManager.LoadScene("Menue");
        }
    }
}