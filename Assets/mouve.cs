using UnityEngine;

public class ChataigneMovement : MonoBehaviour
{
    public float speed = 5f;

    private float inputX = 0f;
    private float inputY = 0f;

    void Update()
    {
        // DEBUG
        Debug.Log("X: " + inputX + " | Y: " + inputY);

        // MOUVEMENT
        Vector3 move = new Vector3(inputX, 0, inputY);
        transform.Translate(move * speed * Time.deltaTime);
    }

    public void Move(Vector2 direction)
    {
        OnMoveX(direction.x);
        OnMoveY(direction.y);
    }

    public void OnMoveX(float value)
    {
        inputX = Mathf.Clamp(value, -1f, 1f);
    }

    public void OnMoveY(float value)
    {
        inputY = Mathf.Clamp(value, -1f, 1f);
    }
}