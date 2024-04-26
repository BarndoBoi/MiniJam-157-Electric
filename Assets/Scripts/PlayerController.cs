using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    private Rigidbody2D body;
    [SerializeField] private float moveSpeed = 10.0f;
    [SerializeField] private float dragForce = 2.0f;
    private Vector2 input;


    //getter in case we want to find player speed for some reason later.
    public float getSpeed(){
        return moveSpeed;
    }
    
    private void Awake(){
        body = GetComponent<Rigidbody2D>();
    }

    void Update(){
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        body.drag = dragForce;
    }

    void FixedUpdate(){
        moveCharacter(input);
    }

    void moveCharacter(Vector2 direction){
        body.AddForce(direction * moveSpeed);
    }

}
