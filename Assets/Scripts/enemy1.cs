using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour {

    public float speed = 100f;

	void Update () {
        if(player.gameStarted && !player.gameOver)
            transform.Rotate(0f, 0f, speed * Time.deltaTime);
	}
}
