using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;

    Vector3 movement = Vector3.zero;
    [Header("Movement")]
    public float moveSpeed = 5f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        movement = new Vector3(horizontal * moveSpeed, vertical * moveSpeed, 0);
    }
    void FixedUpdate() {
        rb.MovePosition(transform.position + movement);
    }






}