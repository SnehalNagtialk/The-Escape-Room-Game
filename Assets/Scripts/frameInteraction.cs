using UnityEngine;
using System.Collections;
public class frameInteraction : MonoBehaviour
{
    public Animator frameAnimator; // Reference to the locked box animator
    public AudioSource FrameOpenSound; // Sound effect when opening the box
    public GameObject knifeIcon; // Reference to the key icon in inventory
    public GameObject frameMessage;

    void OnMouseDown()
    {
        if (Gamemanager.Instance.hasKnife)
        {
            FrameOpenSound.Play();
            frameAnimator.SetBool("frame", true);
            Gamemanager.Instance.hasKnife = false;
            Gamemanager.Instance.hasFoundPaintingClue = true;
            knifeIcon.SetActive(false);
            frameMessage.SetActive(false);


        }
        else
        {
            frameMessage.SetActive(true);
            StartCoroutine(HideMessage());

        }

        IEnumerator HideMessage()
        {
            yield return new WaitForSeconds(2f); // Wait for 2 seconds
            frameMessage.SetActive(false); // Hide locked message
        }

    }
}
