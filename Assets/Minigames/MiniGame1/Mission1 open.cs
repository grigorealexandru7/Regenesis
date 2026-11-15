using UnityEngine;

public class Mission1open : MonoBehaviour
{
    public GameObject MISSION1;
    public GameObject counter;
    private int ok = 1;
    private void OnMouseDown()
    {
        if(ok ==1)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            counter.SetActive(false);
            MISSION1.SetActive(true);
            ok = 0;
                 
        }
        
    }
}
