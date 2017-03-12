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

    private SpriteRenderer spriteRenderer;


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
