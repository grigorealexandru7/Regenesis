using UnityEngine;

public class Plant : MonoBehaviour, IInteractable
{
    public Seedtaken seedtaken;
    public PlantedCount planted;
    public GameObject plant;
    private int ok = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Interact()
    {
        if (seedtaken.taken == true && ok ==1)
        {
            plant.SetActive(true);
            planted.planted--;
            ok = 0;
        }
    }
}
