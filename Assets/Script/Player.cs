using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public SpriteRenderer playerSprite;
    public Animator animator;

    private void Awake()
    {
        if (playerSprite == null) playerSprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        playerSprite.flipX = false;
    }

    void Update()
    {
        //animator.SetBool("IsAttack", false);
    }

    public void move(bool flip)
    {
        playerSprite.flipX = flip;
    }

    public void attack(bool isAttack)
    {
        animator.SetBool("IsAttack", isAttack);
        //attackEvent();
    }
}
