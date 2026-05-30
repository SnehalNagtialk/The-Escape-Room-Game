using UnityEngine;

public class inventoy : MonoBehaviour
{
    public GameObject keyIcon;   // Reference to the Key Icon in the UI
    public GameObject KnifeIcon; // Reference to the Knife Icon in the UI
  
    void Update()
    {
        // Checks if the player has the key and updates the key icon visibility
        keyIcon.SetActive(Gamemanager.Instance.hasKey);

        // Checks if the player has the knife and updates the knife icon visibility
         KnifeIcon.SetActive(Gamemanager.Instance.hasKnife);
       
    }
}
