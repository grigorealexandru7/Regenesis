using UnityEngine;

public class Plant : MonoBehaviour
{
    public Seedtaken seedtaken;
    public PlantedCount planted;
    public GameObject plant;
    private int ok = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (seedtaken.taken == true && ok ==1)
        {
            plant.SetActive(true);
            planted.planted--;
            ok = 0;
        }
    }
}
