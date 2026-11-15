using UnityEngine;

public class Mission1open : MonoBehaviour, IInteractable
{
    public GameObject MISSION1;
    public GameObject counter;
    private int ok = 1;
    public void Interact()
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
