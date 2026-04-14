using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public Transform spawnPoint;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Respawn(collision.gameObject);
        }
    }

    void Respawn(GameObject player)
    {
        Rigidbody rb = player.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero; // reset vitesse
        }

        player.transform.position = spawnPoint.position;
    }
}