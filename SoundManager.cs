using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	private AudioSource m_aSource;

	private void Start()
	{
		m_aSource = GetComponent<AudioSource>();
	}

	public void PlayClip(AudioClip clip)
	{
		m_aSource.PlayOneShot(clip);
	}
}
