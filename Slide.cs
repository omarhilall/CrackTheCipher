using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
	public GameObject m_content;
	public Animator m_animator;

    public void Show()
	{
		m_content.SetActive(true);
	}

	public void Hide()
	{
		m_content.SetActive(false);
	}
}
