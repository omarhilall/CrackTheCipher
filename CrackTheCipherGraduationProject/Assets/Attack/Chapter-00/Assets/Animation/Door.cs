using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    //public Transform player;
    //public Transform door;
    public bool haveKey;
    bool canOpen;
    bool IsOpend;
    // Update is called once per frame
    void Update()
    {
        
    }


    //public void OpenTheDoor()
    //{
    //    float distance = Vector3.Distance(player.position, door.position);

    //    if (distance <= 3)
    //    {
    //        anim.SetBool("Near", true);
    //    }
    //    else
    //    {
    //        anim.SetBool("Near", false);
    //    }
    //}
   
    private void OnTriggerEnter(Collider other)
    {
        if(haveKey && !canOpen)
        {
            return;
        }
        
        if (IsOpend) return;
        OpenTheDoor();

        IsOpend = true;
    }


    public void DoorCanOpen()
    {
        canOpen = true;
    }

    public void OpenTheDoor()
    {
        anim.SetBool("Near", true);

    }
    public void CloseTheDoor()
    {
        anim.SetBool("Near", false);

    }


}
