using UnityEngine;

public class NotebookInteraction : MonoBehaviour
{
    public GameObject BookPuzzle; 
    public GameObject BookPuzzleAnswer;
    void OnMouseDown()
    {
        BookPuzzle.SetActive(true);
        BookPuzzleAnswer.SetActive(true);
    }

    
}

