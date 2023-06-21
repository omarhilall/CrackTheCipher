using UnityEngine;

public class UIState : MonoBehaviour
{
    public void ChangeState(GameObject obj) => obj.SetActive(!obj.activeSelf);
}
