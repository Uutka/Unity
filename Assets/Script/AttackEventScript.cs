using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEventScript : MonoBehaviour
{
    public Animator animator;

    public void attackEvent()
    {
       animator.SetBool("IsAttack", false);
    }

}
