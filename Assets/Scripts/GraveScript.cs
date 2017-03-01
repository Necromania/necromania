using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveScript : MonoBehaviour {

    public Sprite skeletonSprite;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void raiseGrave()
    {
        spriteRenderer.sprite = skeletonSprite;
    }
}
