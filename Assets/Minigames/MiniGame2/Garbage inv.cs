using UnityEngine;

public class Garbageinv : MonoBehaviour
{
    public int garbage = 5;
    public Mission mission;
    public GameObject SIGN;
    private int ok = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (garbage == 0 && ok == 1)
        {
            mission.left--;
            ok = 0;
            SIGN.SetActive(false);
            
        }
    }
}
