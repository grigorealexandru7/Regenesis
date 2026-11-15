using UnityEngine;

public class Color1 : MonoBehaviour
{
    public static Color1 selected;
    public int code = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void This()
    { 
        selected = this;
    }
}
