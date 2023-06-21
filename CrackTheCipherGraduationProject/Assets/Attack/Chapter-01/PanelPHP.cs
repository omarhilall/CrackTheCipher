using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PanelPHP : MonoBehaviour
{
    [SerializeField] private List<string> rightCodes = new List<string>();
    [SerializeField] private List<TMPro.TMP_InputField> inputsCodes = new List<TMPro.TMP_InputField>();
    [SerializeField] private List<Button> buttonsCheckCodes = new List<Button>();

    [SerializeField] private Image imageResult;
    [SerializeField] private GameObject panelWin;
    [SerializeField] private GameObject panelLose;

    [SerializeField] private int amountTimes;

    public void CheckInput(int num)
    {
        buttonsCheckCodes[num].interactable = false;

        if (inputsCodes[num].text == rightCodes[num])
        {
            inputsCodes[num].textComponent.color = Color.green;
            rightTimes++;
        }
        else
        {
            inputsCodes[num].textComponent.color = Color.red;
            loseTimes++;
        }

        CheckWin();
    }


    private int loseTimes;
    private int rightTimes;
    private async void CheckWin()
    {
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

        for (int i = 0; i < rightCodes.Count; i++)
        {
            inputsCodes[i].textComponent.color = Color.white ;
            buttonsCheckCodes[i].interactable = true;
        }

        panelWin.SetActive(false);
        panelLose.SetActive(false);
        loseTimes = 0;
        rightTimes = 0;
    }
}

