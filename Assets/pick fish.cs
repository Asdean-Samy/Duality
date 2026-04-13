using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Poisson récupéré !");

            // détruire l'objet
            Destroy(gameObject);

            // appeler la fin du jeu
            GameManager.instance.WinGame();
        }
    }
}