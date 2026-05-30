using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager Instance; // Singleton Instance
    public bool hasKey = false;        // Stores if player has Key
   public bool hasKnife = false;
    public bool hasFoundPaintingClue = false;
    private void Awake()
    {
        // Singleton Pattern
        if (Instance == null)
        {
            Instance = this; // Store current instance
            DontDestroyOnLoad(gameObject); // Keep GameManager in all scenes
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
}
