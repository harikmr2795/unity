using UnityEngine;

public class player : MonoBehaviour
{
    public static bool gameStarted = false;
    public static bool gameOver = false;
    Rigidbody2D rb;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            gameStarted = true;
            cameraAnchor.cameraRb.velocity = Vector2.up * cameraAnchor.cameraSpeed;
        }

        if (Input.GetMouseButtonUp(0) && !gameOver)
            GameOver();

        if (gameStarted && !gameOver)
            rb.MovePosition(cam.ScreenToWorldPoint(Input.mousePosition));
    }

    void OnTriggerEnter2D()
    {
        GameOver();
    }

    void GameOver()
    {
        gameOver = true;
        cameraAnchor.cameraRb.velocity = Vector2.up * 0;
        CameraShake.Shake(0.25f,0.25f);
    }
}
