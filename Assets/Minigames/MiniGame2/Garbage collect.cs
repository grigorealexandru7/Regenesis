using UnityEngine;

public class Garbagecollect : MonoBehaviour,IInteractable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Garbageinv inv;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Interact()
    {
        inv.garbage--;
        Destroy(gameObject);
    }
}
