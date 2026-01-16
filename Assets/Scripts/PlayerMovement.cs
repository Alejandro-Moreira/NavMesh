using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); 
        float moveZ = Input.GetAxisRaw("Vertical");   

        Vector3 movement = new Vector3(moveX, 0f, moveZ).normalized * speed;
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }
}
