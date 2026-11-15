using UnityEngine;

public class Orb : MonoBehaviour
{
    public static Orb selected;

    public void Do()
    { 
        selected = this;
    }
}
