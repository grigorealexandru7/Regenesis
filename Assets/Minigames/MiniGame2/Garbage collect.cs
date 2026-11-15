using UnityEngine;

public class Garbagecollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Garbageinv inv;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        inv.garbage--;
        Destroy(gameObject);
    }
}
