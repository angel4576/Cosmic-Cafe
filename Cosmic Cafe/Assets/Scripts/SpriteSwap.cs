using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwap : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite emptySprite;
    public Sprite heldSprite;
    private bool sp1 = true;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.held == 0 && !sp1)
        {
            spriteRenderer.sprite = emptySprite;
            sp1 = true;
        }
        else if(PlayerMovement.held != 0 && sp1)
        {
            spriteRenderer.sprite = heldSprite;
            sp1 = false;
        }   
    }
}
