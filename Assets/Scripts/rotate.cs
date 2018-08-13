using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed = 100f;

	void Update () {
        if (player.gameStarted && !player.gameOver)
            rb.MoveRotation(rb.rotation + speed * Time.deltaTime);
            //transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}
}
