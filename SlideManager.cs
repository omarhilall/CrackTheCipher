using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideManager : MonoBehaviour
{
    public Slide[] m_slides;
	private Slide m_currentSlide;

    private void Start()
    {
        // Lets hide all slides on start
        for (int i = 0; i < m_slides.Length; i++)
        {
			m_slides[i].Hide();
        }
    }

    public void ShowSlide(Slide obj)
    {
		if (m_currentSlide == obj)
			return;

        // Hide all slides
        for (int i = 0; i < m_slides.Length; i++)
        {
			m_slides[i].Hide();
        }

		// Show selected slide
		m_currentSlide = obj;

		obj.Show();
    }
}