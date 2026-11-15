using System.Diagnostics.Metrics;
using UnityEngine;

public class FishCount : MonoBehaviour
{
    public int aided = 4;
    public GameObject MISSION2;
    public GameObject Counter;
    public Mission mission;
    public GameObject DeadFish;
    public GameObject LiveFish;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (aided == 0)
        {
            MISSION2.SetActive(false);
            Counter.SetActive(true);
            DeadFish.SetActive(false);
            LiveFish.SetActive(true);
            
            mission.left--;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            
        }
    }
}
