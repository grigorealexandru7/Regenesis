using UnityEngine;

public class Uncolor1 : MonoBehaviour
{
    public int codeu = 1;
    public Color1 color1;
    public Correct correct;
    public GameObject Color;
    public GameObject Uncolor;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void This()
    {
        Color1 item = Color1.selected;
        if (item != null && color1.code == codeu)
        {
            Cursor.visible = true;
            correct.correctans--;
            Uncolor.SetActive(false);
            Color.SetActive(false);
            Color1.selected = null;
            correct.correctans--;

        }
    }
}
