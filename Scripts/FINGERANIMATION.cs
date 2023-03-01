using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FINGERANIMATION : MonoBehaviour
{
    private Animator m_animator;
    public AnimationClip m_fingerActionDown;
    public AnimationClip m_fingerActionUp;

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_animator.Play(m_fingerActionDown.name);
        }
        if (Input.GetMouseButtonUp(0))
        {
            m_animator.Play(m_fingerActionUp.name);
        }
    }
}
