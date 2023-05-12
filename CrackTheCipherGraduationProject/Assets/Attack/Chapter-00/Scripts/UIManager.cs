using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI msgText;
    [Space]
    [SerializeField] private GameObject popUpMsg;
    [Space]
    [Header("Computer")]
    [SerializeField] private List<GameObject> obejctsToActiveWhenHackingDone;
    [SerializeField] private GameObject hackingBG;
    [SerializeField] private Slider hackSlider;
    [SerializeField] private TextMeshProUGUI timerText;
    [Space]
    [Header("Restarting Electricity")]
    [SerializeField] private GameObject electricBG;
   // [SerializeField] private Slider electricSlider;
    [Space]
    [SerializeField] private GameObject doneMsgBG;
    [Space]
    [Header("Changind Cloths")]
    [SerializeField] public GameObject changeColthBG;
    [SerializeField] private Slider changinColthSlider;
    [Space]
    public GameState gameState;
    public GameObject winPanel;

    [SerializeField] Door door;
    [SerializeField] TextMeshProUGUI textOBJECTIVES;
    [SerializeField] string[] objectives;

    public GameObject currentGuard;

    public bool canEscape;
    public bool escaped;

    private bool canHackComputer;

    public static UIManager instance;
    PlayerMovement player;
    private void Awake()
    {
        player = FindObjectOfType<PlayerMovement>();
        
    }
    void Start()
    {
        ShowObjective(0);

           escaped = false;
        canEscape = false;
        hackSlider.value = 0f;
        if (instance == null)
            instance = this;

        canHackComputer = false;

        foreach (var item in obejctsToActiveWhenHackingDone)
        {
            item.SetActive(false);
        }
    }

    private void Update()
    {
        if (gameState == GameState.GameOver || gameState == GameState.GameWin)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                gameState = GameState.None;
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
            }
        }

        
        if (Input.GetKeyDown(KeyCode.F))
        {


            if (gameState == GameState.TakeOutPower)
            {
                //SetMsgText(string.Empty);
                electricBG.SetActive(true);
                // currentGuard.GetComponent<Collider>().enabled = false;
                //  gameState = GameState.None;


                StartCoroutine(RestartingElectrcity());
            }
            if (gameState == GameState.ChangeClothes)
            {
                SetMsgText(string.Empty);
                
                changeColthBG.SetActive(true);
                currentGuard.GetComponent<Collider>().enabled = false;
                gameState = GameState.None;

                StartCoroutine(ChangingCloths());
            }

            if (gameState == GameState.TakeDownEnemy)
            {
                currentGuard.GetComponent<Animator>().enabled = false;
                
                SetMsgText(string.Empty);
                currentGuard = null;
                gameState = GameState.None;
            }

            if (gameState == GameState.Hack)
            {
                if (canHackComputer)
                {
                    popUpMsg.SetActive(false);
                    hackingBG.SetActive(true);
                    StartCoroutine(Hacking());
                    canHackComputer = false;
                    gameState = GameState.None;
                    currentGuard.GetComponent<Collider>().enabled = false;
                }
            }

            if (gameState == GameState.None)
            {

            }
        }

    }

    private IEnumerator RestartingElectrcity()
    {
        //electricSlider.value = 0;
        //while (electricSlider.value < electricSlider.maxValue)
        //{
        //    yield return null;
        //    electricSlider.value += Time.deltaTime;
        //}

      //  electricBG.SetActive(false);
       // yield return new WaitForSeconds(0.2f);
       // doneMsgBG.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        doneMsgBG.SetActive(false);
        ShowObjective(2);

    }

    private IEnumerator ChangingCloths()
    {
        player.canMove = false;
        changinColthSlider.value = 0f;
        while (changinColthSlider.value<changinColthSlider.maxValue)
        {
            yield return null;
            changinColthSlider.value += Time.deltaTime;
        }

        changeColthBG.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        doneMsgBG.SetActive(true);
        yield return new WaitForSeconds(2f);
        doneMsgBG.SetActive(false);
        player.canMove = true;
        door.DoorCanOpen();
        ShowObjective(1);

    }

    private IEnumerator WaitThenHideDoneObject()
    {
        yield return new WaitForSeconds(2f);
        doneMsgBG.SetActive(false);
        changeColthBG.SetActive(false);
    }

    private IEnumerator Hacking()
    {
        player.canMove = false;

        hackSlider.value = 0f;

        while (hackSlider.value < hackSlider.maxValue)
        {
            yield return null;
            hackSlider.value += Time.deltaTime;
        }
        hackingBG.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        doneMsgBG.SetActive(true);
        yield return new WaitForSeconds(2f);

        foreach (var item in obejctsToActiveWhenHackingDone)
        {
            item.SetActive(true);
        }

        doneMsgBG.SetActive(false);
        yield return new WaitForSeconds(1f);
        canEscape = true;
        player.canMove = true;
        ShowObjective(4);
        StartCoroutine(EscapeTime());
    }

    private IEnumerator EscapeTime()
    {
        int time = 25;
        while (time > 0)
        {
            timerText.text = "Escape Before guards get suspicious : " + time;
            yield return new WaitForSeconds(1f);
            time--;
        }

        if (!escaped)
        {
            SetMsgText("Game Over Failed To escape.\nPress R To Retry!");
            gameState = GameState.GameOver;
            canEscape = false;
        }
        
    }

    public void TogglePopUp(bool isOn)
    {
        if (!isOn)
        {
            hackSlider.value = 0;
            StopAllCoroutines();
            hackingBG.SetActive(false);
            doneMsgBG.SetActive(false);
        }
        popUpMsg.SetActive(isOn);

        canHackComputer = isOn;
    }


    public void SetMsgText(string msg)
    {
        msgText.text = msg;
    }

    public void ShowObjective(int i)
    {
        if (objectives.Length == 0) return;
        textOBJECTIVES.text = objectives[i];

    }
}


public enum GameState
{
    TakeDownEnemy,
    ChangeClothes,
    Hack,
    TakeOutPower,
    GameOver,
    GameWin,
    None
}

