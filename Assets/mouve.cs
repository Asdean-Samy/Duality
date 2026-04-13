using UnityEngine;

public class ChataigneMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    float inputX = 0f;
    float inputY = 0f;

    float lastMessageTime;

    Rigidbody rb;
    bool isGrounded = true;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Stop si plus de signal
        if (Time.time - lastMessageTime > 0.2f)
        {
            inputX = 0f;
            inputY = 0f;
        }

        Debug.Log("X: " + inputX + " | Y: " + inputY);

        // Déplacement gauche / droite
        Vector3 move = new Vector3(inputX, 0f, 0f);
        transform.Translate(move * speed * Time.deltaTime);

        // Rotation du perso (regarde la direction)
        if (inputX > 0.1f)
            transform.localScale = new Vector3(1f, 1f, 1f);
        else if (inputX < -0.1f)
            transform.localScale = new Vector3(-1f, 1f, 1f);

        // Jump 
        if (inputY > 0.5f && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // détecte le sol
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    public void OnMoveX(float value)
    {
        inputX = Mathf.Clamp(value, -1f, 1f);
        lastMessageTime = Time.time;
    }

    public void OnMoveY(float value)
    {
        inputY = Mathf.Clamp(value, -1f, 1f);
        lastMessageTime = Time.time;
    }
}