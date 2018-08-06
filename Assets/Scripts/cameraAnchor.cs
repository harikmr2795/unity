using UnityEngine;

public class cameraAnchor : MonoBehaviour {

    public static float cameraSpeed = 3f;
    public static Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {
        //if (player.gameStarted && !player.gameOver)
        //{
        //    rb.velocity = Vector2.up * cameraSpeed;
        //}

        //if (player.gameOver)
        //{
        //    rb.velocity = Vector2.up * 0;
        //}

    }
}
