using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float ForceMultiplier;
	
    

	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * ForceMultiplier, ForceMode2D.Force);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(-Vector2.right * ForceMultiplier / 2f, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * ForceMultiplier / 2f, ForceMode2D.Force);
        }

    }
}
