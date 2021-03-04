using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //public Text Panel_info;
    public Button Left;
    public Button Right;
    //public SpriteRenderer playerSprite;
    private Player pc;
    private bool flip = false;
    //private MoveState _moveState = MoveState.Idle;
    // Start is called before the first frame update
    void Start()
    {
        //Panel_info.text = "None";
        pc = GetComponent<Player>();
        Left.onClick.AddListener(OnClickLeft);
        Right.onClick.AddListener(OnClickRight);
        //playerSprite.flipX = false;
    }

    public void OnClickLeft()
    {
       // Panel_info.text = "Left";
        flip = true;
    }

    public void OnClickRight()
    {
        //Panel_info.text = "Right";
        flip = false;
    }

    // Update is called once per frame
    void Update()
    {
        pc.move(flip);
    }
}
