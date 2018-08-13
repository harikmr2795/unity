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

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            gameStarted = true;
            if(!gameOver)
                cameraAnchor.cameraRb.velocity = Vector2.up * cameraAnchor.cameraSpeed;
        }

        if (Input.GetMouseButtonUp(0))
        {
            gameOver = true;
            cameraAnchor.cameraRb.velocity = Vector2.up * 0;
            Debug.Log("Game Over");
        }

        if (gameStarted && !gameOver)
            rb.MovePosition(cam.ScreenToWorldPoint(Input.mousePosition));
            //rb.position = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    void OnTriggerEnter2D()
    {
        gameOver = true;
        cameraAnchor.cameraRb.velocity = Vector2.up * 0;
        Debug.Log("Game Over");
    }
}
