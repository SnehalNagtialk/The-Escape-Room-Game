using UnityEngine;

public class CursorChange : MonoBehaviour
{
    public Texture2D customCursor;  // Assign your cursor texture in the Inspector
    public Vector2 hotSpot = Vector2.zero;  // Set the cursor's hotspot

    void Start()
    {
        Cursor.SetCursor(customCursor, hotSpot, CursorMode.Auto);
    }
}
