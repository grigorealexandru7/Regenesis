using UnityEngine;
using TMPro;
public class Mission : MonoBehaviour
{
    public int left = 5;
    public TMP_Text counter;
    public int color = 0;
    public GameObject water;
    public GameObject badwater;

    public GameObject DONEUI;
    public GameObject MISSION;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = left.ToString();
        if(left==0)
        {
            color = 1;
            water.SetActive(true);
            badwater.SetActive(false);
            DONEUI.SetActive(true);
            MISSION.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
