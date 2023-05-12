using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PanelDataBase : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField inputCode;
    [SerializeField] private TMPro.TextMeshProUGUI textResult;
    [SerializeField] private Image imageResult;
    [SerializeField] private GameObject panelWin;
    [SerializeField] private GameObject panelLose;

    [Space]
    [SerializeField] private List<RequestSQL> requestSQLs = new List<RequestSQL>();

    [Space]
    [SerializeField] private int amountTimes;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            CheckCode();
        }
    }

    private int loseTimes;
    private int rightTimes;
    private void CheckCode()
    {
        string code = inputCode.text;

        if (string.IsNullOrEmpty(code))
        {
            textResult.text = "INPUT_EMPY";
            return;
        }

        for (int i = 0; i < requestSQLs.Count; i++)
        {
            if (requestSQLs[i].code == code)
            {
                textResult.text = "";

                foreach (var sql in requestSQLs[i].answer)
                {
                    textResult.text += sql + "\n" + "\n";
                }

                rightTimes++;
                CheckWin();
                return;
            }
        }

        loseTimes++;
        textResult.text = "UNKNOW_CODE";
        CheckWin();
    }

    private async void CheckWin()
    {
        inputCode.text = "";

        if (amountTimes == rightTimes)
        {
            imageResult.color = Color.green;
            panelWin.SetActive(true);
            await Task.Delay(3000);
            gameObject.SetActive(false);
        }
        else if (amountTimes == loseTimes || rightTimes + loseTimes == amountTimes)
        {
            imageResult.color = Color.red;
            panelLose.SetActive(true);
            await Task.Delay(3000);
            gameObject.SetActive(false);

        }
    }

    private void OnDisable()
    {
        textResult.text = "";

        panelWin.SetActive(false);
        panelLose.SetActive(false);
        loseTimes = 0;
        rightTimes = 0;
    }
}



[Serializable]
public class RequestSQL
{
    public string code;
    public List<string> answer = new List<string>();
}
