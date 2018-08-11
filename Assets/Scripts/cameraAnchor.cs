using UnityEngine;

public class cameraAnchor : MonoBehaviour {

    public static float cameraSpeed = 3f;
    public static Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
