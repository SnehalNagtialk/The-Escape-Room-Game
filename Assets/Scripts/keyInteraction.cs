using UnityEngine;

public class keyInteraction : MonoBehaviour
{
    public GameObject keyIcon; // Reference to the key icon in inventory
   public AudioSource pickupSound; // Sound effect when picking up the key

    void OnMouseDown()
    {
        Gamemanager.Instance.hasKey = true; // Mark key as collected
        keyIcon.SetActive(true); // Show key icon in inventory
        pickupSound.Play(); // Play pickup sound
        Destroy(gameObject); // Hide key object after pickup
        Debug.Log("Key Collected!");
    }
}
