using UnityEngine;
using TMPro;
public class Mission : MonoBehaviour
{
    public int left = 6;
    public TMP_Text counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = left.ToString();
    }
}
