using UnityEngine;

public class knifeinteraction : MonoBehaviour
{
    public GameObject knifeIcon; // Reference to the key icon in inventory
    //public GameObject keyIcon; // Reference to the key icon in inventory
    public AudioSource pickupSound; // Sound effect when picking up the key

    void OnMouseDown()
    {


        if (Gamemanager.Instance.hasKey)
        {
            Gamemanager.Instance.hasKnife = true; // Mark key as collected
            knifeIcon.SetActive(true); // Show key icon in inventory
                                       //keyIcon.SetActive(false); // Show key icon in inventory
            pickupSound.Play(); // Play pickup sound
            Destroy(gameObject); // Hide key object after pickup
            Debug.Log("Knife Collected!");
        }
        else
        {
            Gamemanager.Instance.hasKnife = false;
        }

    }
}