using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Poisson récupéré !");

            
            Destroy(gameObject);

            // call endgame
            GameManager.instance.WinGame();
        }
    }
}