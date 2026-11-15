using System.Diagnostics.Metrics;
using UnityEngine;
public class Count : MonoBehaviour
{
    public int fish = 5;
    public GameObject MISSION;
    public GameObject counter;
    public Mission mission;
    void Start()
    {
        
    } 
    public GameObject morti;

    public GameObject MISSION1;
    // Update is called once per frame
    private int ok = 1;
    void Update()
    {
        if (fish == 0 && ok == 1) 
            {
                MISSION.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked; 
                Cursor.visible = false;
                morti.SetActive(false);
                counter.SetActive(true);
                mission.left--;
                ok = 0;
                Destroy(MISSION1);
            }
    }
}
