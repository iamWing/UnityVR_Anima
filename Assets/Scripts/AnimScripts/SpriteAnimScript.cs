using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimScript : MonoBehaviour {

    [SerializeField]
    private Sprite[] animSprites;
    [SerializeField]
    private float refreshRate = 0.5f;

    private SpriteRenderer spriteRenderer;
    private int currentSprite = 0;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
        InvokeRepeating("UseNextSprite", refreshRate, refreshRate);

	}
    public void UseNextSprite()
    {
        currentSprite++;
        if (currentSprite == animSprites.Length)
        {
            currentSprite = 0;
        }
        spriteRenderer.sprite = animSprites[currentSprite];
    }
	

}
