using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //public Text Panel_info;
    [SerializeField]
    private Button Left;
    [SerializeField]
    private Button Right;
    //public SpriteRenderer playerSprite;
    [SerializeField] private Player playerCharacter;
    private bool flip = false;
    //private MoveState _moveState = MoveState.Idle;
    // Start is called before the first frame update
    private void Awake()
    {
        if (playerCharacter == null) GameObject.FindGameObjectsWithTag("player");
    }
    private void Start()
    {
        Left.onClick.AddListener(OnClickLeft);
        Right.onClick.AddListener(OnClickRight);
    }

    private void Update()
    {
        //playerCharacter.animator.SetBool("IsAttack", false);
    }

    private void OnClickLeft()
    {
        Debug.Log("Click left");
        playerCharacter.move(true);
        playerCharacter.attack(true);
        
    }

    private void OnClickRight()
    {
        Debug.Log("Click Right");
        playerCharacter.move(false);
        playerCharacter.attack(true);
        
    }

}
