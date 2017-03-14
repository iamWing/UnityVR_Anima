using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChestScript : MonoBehaviour {

    [SerializeField]
    Sprite chestClosed, chestOpened;

    [SerializeField]
    GameObject particleSystem;
    [SerializeField]
    float particleSystemLifeTime = 5.0f;

    [SerializeField]
    GameObject treasureChestSprite;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = treasureChestSprite.GetComponent<SpriteRenderer>();
        InvokeRepeating("Execute", 5.0f,10f);
    }


	public void Execute()
    {
        particleSystem.SetActive(true);
        spriteRenderer.sprite = chestClosed;
        Invoke("DisableParticleSystem", particleSystemLifeTime);


    }
    public void DisableParticleSystem()
    {
        particleSystem.SetActive(false);
    }
}
