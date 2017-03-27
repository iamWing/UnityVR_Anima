/**
 * This script is similar to SpriteAnimScript but replace the sprites 
 * in Image instead of SpriteRenderer.
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NonStaticSpriteAnimScript : MonoBehaviour {

	[SerializeField] private Sprite[] m_animSprites;
	[SerializeField] private float refreshRate = 0.5f;

	private Image m_image;
	private int currentSprite = 0;

	// Use this for initialization
	void Start () {
		m_image = GetComponent<Image> ();
		InvokeRepeating ("UpdateSprite", refreshRate, refreshRate);
	}

	void UpdateSprite() {
		if (currentSprite == m_animSprites.Length)
			currentSprite = 0;
		m_image.sprite = m_animSprites [currentSprite];

		currentSprite++;
	}
}
