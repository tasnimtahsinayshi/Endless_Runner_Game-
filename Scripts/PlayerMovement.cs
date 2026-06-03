using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 6;
    public float horizontalSpeed = 3;
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;
    public bool isStumbling = false;

    void Update()
    {
        Debug.Log("MOVING: " + transform.position); // ADD THIS ONE LINE
    
        if (isStumbling) return;
        transform.position += Vector3.forward * Time.deltaTime * playerSpeed;
        float h = Input.GetAxis("Horizontal");
        if (h < 0 && transform.position.x > leftLimit)
            transform.position += Vector3.left * Time.deltaTime * horizontalSpeed;
        else if (h > 0 && transform.position.x < rightLimit)
            transform.position += Vector3.right * Time.deltaTime * horizontalSpeed;
    }
}