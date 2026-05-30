using UnityEngine;
using System.Collections;
public class LockedBoxinteraction : MonoBehaviour
{
    public Animator boxAnimator; // Reference to the locked box animator
    public AudioSource boxOpenSound; // Sound effect when opening the box
    public AudioSource KeySound; // Sound effect when opening the box
    public GameObject keyIcon; // Reference to the key icon in inventory
    public GameObject knifeIcon; // Reference to the key icon in inventory
    public GameObject LockedBoxMessage;

    void OnMouseDown()
    {
        if (Gamemanager.Instance.hasKey)
        {
            boxAnimator.SetBool("isopenBox", true);
            LockedBoxMessage.SetActive(false);
            Gamemanager.Instance.hasKey = false;
            boxOpenSound.Play();
            keyIcon.SetActive(false);
            KeySound.Play();
            knifeIcon.SetActive(true);
            

        }
        else
        {
            LockedBoxMessage.SetActive(true);
            StartCoroutine(HideMessage());
           
        }

        IEnumerator HideMessage()
        {
            yield return new WaitForSeconds(2f); // Wait for 2 seconds
            LockedBoxMessage.SetActive(false); // Hide locked message
        }





    }
}
