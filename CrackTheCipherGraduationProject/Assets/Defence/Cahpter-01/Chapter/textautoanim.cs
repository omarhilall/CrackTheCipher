using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class textautoanim : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _textMeshPro;
    public string[] stringArray;
    [SerializeField] float timeBetweenCharacters;
    [SerializeField] float timeBetweenWords;
    int i = 0;
    [SerializeField] Button button;

    void Start()
    {
       
        EndCheck();
    }

    void EndCheck()
    {
       
        if (i <= stringArray.Length - 1)
        {
            _textMeshPro.text = stringArray[i];

                StartCoroutine(TextVisible());

            if(i == stringArray.Length - 1) // maged
            {
                if (button != null)
                    button.interactable = true;
            }
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
                Invoke("EndCheck", timeBetweenWords);
                break;
            }

            counter += 1;
            yield return new WaitForSeconds(timeBetweenCharacters);
        }

    }



    public void RestartTheSceen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoToMenue()
    {
        SceneManager.LoadScene("Menue");
    }
}
