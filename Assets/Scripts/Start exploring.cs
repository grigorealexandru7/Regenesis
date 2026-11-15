using UnityEngine;

public class Startexploring : MonoBehaviour
{
    public GameObject DONEUI;
    public void Pressed()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        DONEUI.SetActive(false);
        
    }
}
