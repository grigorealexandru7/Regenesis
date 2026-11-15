using UnityEngine;

public class Seedtaken : MonoBehaviour
{
    public bool taken = false;
    public GameObject seed;

    void OnMouseDown()
    {
        taken = true;
        seed.SetActive(false);
    }
}
