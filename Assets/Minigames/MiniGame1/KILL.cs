using UnityEngine;

public class KILL : MonoBehaviour
{
    public GameObject Fish1;
    public Count count;


    public void Do()
    {
        Orb item = Orb.selected;
        if (item != null)
        {
            Cursor.visible = true;
            
            Destroy(Fish1);
            Orb.selected = null;
            count.fish --;
            
        }
    }
}
