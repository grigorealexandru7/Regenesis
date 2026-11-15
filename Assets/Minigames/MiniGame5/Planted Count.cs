using UnityEngine;

public class PlantedCount : MonoBehaviour
{
    public int planted = 5;
    public Mission mission;
    private int ok = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (planted ==0 && ok == 1)
        {
            ok = 0;
            mission.left--;
        }
    }
}
