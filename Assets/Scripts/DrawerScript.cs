using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class DrawerScript : MonoBehaviour
{
    public TMP_InputField answerField;
    public Animator drawerAnimator;
    public AudioSource drawerSound;
    public GameObject BookPuzzle;
    public GameObject BookPuzzleAnswer;
    public GameObject keyObject;
    public GameObject WrongAnswer;



    public void CheckAnswer()
    {
        if (answerField.text == "19")
        {
          
            drawerAnimator.SetBool("isOpen", true);
            keyObject.SetActive(true);
            BookPuzzle.SetActive(false);
            BookPuzzleAnswer.SetActive(false);


            if (drawerSound != null)
            {
               drawerSound.Play();
            }
        }
        else
        {
            WrongAnswer.SetActive(true);
            StartCoroutine(HideMessage());
        }
    }

    IEnumerator HideMessage()
    {
        yield return new WaitForSeconds(1f); // Wait for 2 seconds
        WrongAnswer.SetActive(false); // Hide locked message
    }
}
