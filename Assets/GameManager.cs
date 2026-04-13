using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject winText; // UI à afficher

    void Awake()
    {
        instance = this;
    }

    public void WinGame()
    {
        Debug.Log("VICTOIRE !");

        winText.SetActive(true); // affiche le message
        Time.timeScale = 0f;     // pause le jeu
    }
}