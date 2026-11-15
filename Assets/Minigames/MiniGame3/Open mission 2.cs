using UnityEngine;

public class Openmission2 : MonoBehaviour
{
    public GameObject MISSION2;
    public GameObject counter;
    private int ok = 1;
    private void OnMouseDown()
    {
        if(ok ==1)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            counter.SetActive(false);
            MISSION2.SetActive(true);
            ok = 0;
                 
        }
        
    }
}
