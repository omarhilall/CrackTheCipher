using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlodierController : MonoBehaviour
{
    [SerializeField] Transform CoffePoint;
    [SerializeField] Transform DeathPoint;
    [SerializeField] Transform Door;


    [SerializeField] Door pathroom;
    Animator animator;
    Transform startPosition;
    [SerializeField]bool move = false;
    Transform targetPos;
    private void Start()
    {
        startPosition = transform;
        animator = GetComponent<Animator>();

        StartWalk();
       // move = true;
    }
    public void StartWalk()
    {
        StartCoroutine(Walk());
    }

    void Update()
    {
        if (!move) return;

      transform.position =  Vector3.MoveTowards(transform.position, targetPos.position, Time.deltaTime);

        if(transform.position == targetPos.position)
        {
            print("false");
            move = false;
        }
    }
    IEnumerator Walk()
    {
        targetPos = CoffePoint;
        move = true;
        animator.SetBool("walk", true);
        yield return new WaitUntil(()=> move == false);
        animator.SetBool("walk", false);
        yield return new WaitForSeconds(5);
      //  transform.LookAt(pathroom.transform,Vector3.right);
        targetPos = Door.transform;
        move = true;
        animator.SetBool("walk", true);
        yield return new WaitUntil(()=> move == false);
        animator.SetBool("walk", false);
        pathroom.OpenTheDoor();
        yield return new WaitForSeconds(1);
        targetPos = DeathPoint;
        move = true;
        animator.SetBool("walk", true);
        yield return new WaitUntil(() => move == false);
        animator.SetBool("walk", false);
        pathroom.CloseTheDoor();


    }
}
