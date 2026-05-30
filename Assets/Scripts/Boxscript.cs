using TMPro;
using UnityEngine;

public class Boxscript : MonoBehaviour
{

    public TMP_InputField BoxanswerField;
    public Animator BoxAnimator;
    public AudioSource boxOpenSound;



    public void CheckAnswer()
    {
        if (BoxanswerField.text == "107")
        {

            BoxAnimator.SetBool("isOpen", true);


            //if (drawerSound != null)
            //{
               // drawerSound.Play();
            //}
        }
        else
        {
            Debug.Log("Wrong Answer!");
        }
    }
}
