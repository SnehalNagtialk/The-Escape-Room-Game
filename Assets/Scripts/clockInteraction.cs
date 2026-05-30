
using TMPro;
using UnityEngine;
using System.Collections;

public class clockInteraction : MonoBehaviour
{
    public TMP_InputField answerField;
    public GameObject InputField;
    public GameObject winText;
    public AudioSource doorSound;
    public AudioSource ClockSound;
    public GameObject wrongAnswer;
    private void OnMouseDown()
    {
        if (Gamemanager.Instance.hasFoundPaintingClue)
        {
            ClockSound.Play();
            InputField.SetActive(true);
           
        }
        else
        {
            InputField.SetActive(false);
        }
    }

    public void CheckAnswer()
    {
        if (answerField.text == "1009")
        {
            winText.SetActive(true);
            InputField.SetActive(false);



            if (doorSound != null)

                doorSound.Play();
                ClockSound.Stop();

        }


        else
        {
            wrongAnswer.SetActive(true);
            StartCoroutine(HideMessage());
        }
    }
    IEnumerator HideMessage()
    {
        yield return new WaitForSeconds(1f); // Wait for 2 seconds
        wrongAnswer.SetActive(false); // Hide locked message
    }

}

