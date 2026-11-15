using UnityEngine;

public class Orbselect : MonoBehaviour
{
    public static Orbselect selected;

    public void DoThis()
    { 
        selected = this;
    }
}
