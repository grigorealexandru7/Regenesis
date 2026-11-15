using UnityEngine;

public class FishRepair : MonoBehaviour
{
    //public FishCount fishcount;
    public FishCount count;
    public GameObject AidedFish;
    public GameObject DeadFish;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void DoThis()
    {
        Orbselect item = Orbselect.selected;
        if (item != null)
        {
            Cursor.visible = true;
            AidedFish.SetActive(true);
            DeadFish.SetActive(false);
            Orbselect.selected = null;
            count.aided --;
            
        }
    }
}
