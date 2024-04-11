using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_behavior : MonoBehaviour
{
    private Rigidbody2D joeMama;
    private SpriteRenderer sprite;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        joeMama = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up")){
            print("up");
        }
        if(Input.GetKey("down")){
            print("down");
        }
        if(Input.GetKey("left")){
            print("left");
        }

        if(Input.GetKey("right")){
            print("right");
        }
    }
}
