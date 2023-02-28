using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Button_ShowSlide : MonoBehaviour
{
    public Slide m_slide;
    private SlideManager m_slideManager;
	private SoundManager m_soundManager;

    public Animation m_animator;
    public AnimationClip m_clipDown;
    public AnimationClip m_clipUp;

    public Color upColor;
    public Color downColor;
    public Color hoverColor;

	private bool isHovering;
	private bool isDown;

    public ParticleSystem m_particleDown;

	public AudioClip m_audioDown;
	public AudioClip m_audioUp;

	public Renderer m_renderer;

    private void Start()
    {
        m_slideManager = FindObjectOfType<SlideManager>();
		m_soundManager = FindObjectOfType<SoundManager>();
	}

	private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			m_renderer.material.color = hoverColor;
			isHovering = true;
        }
    }

	private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
			if (isDown)
			{
				ButtonUp();
			}

			m_renderer.material.color = upColor;

			isHovering = false;
        }
    }

	private void Update()
    {
		if (!isHovering)
			return;

        if (Input.GetMouseButtonDown(0))
        {
			ButtonDown();
		}
        else if (Input.GetMouseButtonUp(0))
        {
			ButtonUp();
		}
    }

	private void ButtonDown()
	{
		m_renderer.material.color = downColor;

		isDown = true;

		m_animator.Play(m_clipDown.name);
		m_slideManager.ShowSlide(m_slide);

		m_particleDown.Play();

		m_soundManager.PlayClip(m_audioDown);
	}

	private void ButtonUp()
	{
		isDown = false;

		m_animator.Play(m_clipUp.name);

		m_soundManager.PlayClip(m_audioUp);

		if (isHovering)
			m_renderer.material.color = hoverColor;
		else
			m_renderer.material.color = upColor;
	}
}