using UnityEngine;

public class Correct : MonoBehaviour
{
    public int correctans = 8;
    private int ok = 1;
    public GameObject MISSION4;
    public GameObject counter;
    public Mission mission;

    public GameObject dead;
    public GameObject alive;
    public GameObject sign;
    public GameObject corals;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correctans == 0 && ok == 1)
        {
            ok = 0;
            MISSION4.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked; 
            Cursor.visible = false;
            counter.SetActive(true);
            mission.left--;
            ok = 0;
            Destroy(MISSION4);
            
            dead.SetActive(false);
            alive.SetActive(true);
            sign.SetActive(false);
            corals.SetActive(true);
        }
    }
}
