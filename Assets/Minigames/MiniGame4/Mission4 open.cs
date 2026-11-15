using UnityEngine;

public class Mission4open : MonoBehaviour
{
    public GameObject MISSION4;
    public GameObject counter;
    private int ok = 1;
    private void OnMouseDown()
    {
        if(ok ==1)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            counter.SetActive(false);
            MISSION4.SetActive(true);
            ok = 0;
                 
        }
        
    }
}
