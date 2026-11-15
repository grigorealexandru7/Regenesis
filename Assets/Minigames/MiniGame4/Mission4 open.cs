using UnityEngine;

public class Mission4open : MonoBehaviour,IInteractable
{
    public GameObject MISSION4;
    public GameObject counter;
    private int ok = 1;
    public void Interact()
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
