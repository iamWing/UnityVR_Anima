using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using ProjectUtilities;

namespace ButtonInteractions
{
	public abstract class StartQuitUIEffect : GazeHoverBehaviour
	{

		[SerializeField]
		private float m_speed, m_maxSize, m_minSize, m_incrementBy, m_decrementBy;

		[SerializeField]
		private float m_maxAlpha = 1.0f;

		private float m_incrementAlphaBy, m_decrementAlphaBy;
		private Color m_imgColor;

		[SerializeField]
		private RectTransform m_panel;
		[SerializeField]
		private Image m_image;

		private float m_crtScale, m_crtAlpha = 0.0f;

		protected override void OnHover ()
		{
			m_crtScale = m_minSize;
			m_imgColor = m_image.color;
			m_incrementAlphaBy = (100 / ((m_maxSize - m_minSize) / m_incrementBy / m_maxAlpha)) / 100;
			m_decrementAlphaBy = (100 / ((m_maxSize - m_minSize) / m_decrementBy / m_maxAlpha)) / 100;

			InvokeRepeating ("IncrementScale", m_speed, m_speed);
			CancelInvoke ("DecrementScale");
		}

		protected override void OnHoverExit ()
		{
			CancelInvoke ("DecrementScale");
			CancelInvoke ("IncrementScale");
			m_panel.localScale = new Vector3 (m_minSize, m_minSize, m_minSize);

		}

		private void IncrementScale ()
		{
			m_panel.localScale = new Vector3 (m_crtScale, m_crtScale, m_crtScale);
			m_image.color = new Color (m_imgColor.r, m_imgColor.g, m_imgColor.b, m_crtAlpha);
			if (m_crtScale < m_maxSize) {
				m_crtScale += m_incrementBy;
				m_crtAlpha += m_incrementAlphaBy;
			} else {
				m_crtScale = m_maxSize;
				CancelInvoke ("IncrementScale");
				InvokeRepeating ("DecrementScale", m_speed, m_speed);
			}
		}

		private void DecrementScale ()
		{
			m_panel.localScale = new Vector3 (m_crtScale, m_crtScale, m_crtScale);
			m_image.color = new Color (m_imgColor.r, m_imgColor.g, m_imgColor.b, m_crtAlpha);
			if (m_crtScale > m_minSize) {
				m_crtScale -= m_decrementBy;
				m_crtAlpha -= m_decrementAlphaBy;
			} else {
				m_crtScale = m_minSize;
				CancelInvoke ("DecrementScale");
				InvokeRepeating ("IncrementScale", m_speed, m_speed);
			}
		}
	}
}