using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SpriteRenderer playerSprite;

    void start()
    {
        playerSprite.flipX = false;
    }

    public void move(bool flip)
    {
        playerSprite.flipX = flip;
    }

}
