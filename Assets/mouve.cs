using UnityEngine;

public class ChataigneMovement : MonoBehaviour
{
    public float speed = 5f;

    float inputX = 0f;
    float inputY = 0f;

    float lastMessageTime;

    void Update()
    {
        // STOP AUTOMATIQUE si plus de signal
        if (Time.time - lastMessageTime > 0.2f)
        {
            inputX = 0f;
            inputY = 0f;
        }

        Debug.Log("X: " + inputX + " | Y: " + inputY);

        // MOUVEMENT 2D sur plan XY (comme tu veux)
        Vector3 move = new Vector3(inputX, inputY, 0f);

        transform.Translate(move * speed * Time.deltaTime);
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

    public void Move(Vector2 direction)
    {
        OnMoveX(direction.x);
        OnMoveY(direction.y);
    }
}