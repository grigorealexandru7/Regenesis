using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject TUT;
    public GameObject Story;
    public GameObject Howto;
    public void Change()
    {
        Story.SetActive(false);
        TUT.SetActive(true);
        Howto.SetActive(false);
    }
}
