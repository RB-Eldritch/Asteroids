using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public int lives = 3;

    public float rotationSpeed = 2;
    public float movementSpeed = 5;
    public float acceleration = 20f;
    public float deceleration = .1f;


    private Rigidbody2D playerRB;

    // Use this for initialization
    void Start () {

        Debug.Log("Before setting Rigidbody" + playerRB);
        playerRB = GetComponent<Rigidbody2D>();
        Debug.Log("After setting Rigidbody" + playerRB);
	}
	
	// Update is called once per frame
	void Update () {

        //if user presses specified key
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {

            //Player moves in specified direction
            playerRB.AddForce(transform.right * acceleration);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {

            playerRB.AddForce(-transform.right * acceleration);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {

            //playerRB.AddForce(-transform.right * acceleration);
            transform.rotation *= Quaternion.AngleAxis(rotationSpeed, Vector3.forward);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {

            //playerRB.AddForce(transform.right * acceleration);
            transform.rotation *= Quaternion.AngleAxis(rotationSpeed, Vector3.back);
        }

        //deceleration
        playerRB.velocity += -playerRB.velocity * deceleration;

    }
}
