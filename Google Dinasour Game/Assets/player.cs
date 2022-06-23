using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpPower=1000f;
    Rigidbody2D myRigidbody;
    bool isGround=false;
    void Start()
    {
        myRigidbody=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && isGround){
            myRigidbody.AddForce(Vector2.up*jumpPower*Time.deltaTime*myRigidbody.mass*myRigidbody.gravityScale);

        }

    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag=="Ground"){
            isGround=true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision) {
        if(collision.collider.tag=="Ground"){
            isGround=false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision) {
        if(collision.collider.tag=="Ground"){
            isGround=true;
        }
    }
}
