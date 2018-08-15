using UnityEngine;

public class cameraAnchor : MonoBehaviour {

    public static float cameraSpeed = 5f;
    public static Rigidbody2D cameraRb;

    void Start()
    {
        cameraRb = GetComponent<Rigidbody2D>();
    }

}
