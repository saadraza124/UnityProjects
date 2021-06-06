using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBrick : Brick
{

    [SerializeField]
    Sprite freezerSprite;
    [SerializeField]
    Sprite speedupSprite;
    PickupEffect effect;
    // Start is called before the first frame update
    void Start()
    {
        point = ConfigurationUtils.PickupBrickPoint;
    }
    public PickupEffect Effect
    {
        set
        {
            effect = value;

            // set sprite
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
            if (effect == PickupEffect.Freezer)
            {
                spriteRenderer.sprite = freezerSprite;
            }
            else
            {
                spriteRenderer.sprite = speedupSprite;
            }
        }
    }
    
}
