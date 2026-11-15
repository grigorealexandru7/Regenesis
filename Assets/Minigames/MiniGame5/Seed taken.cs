using UnityEngine;

public class Seedtaken : MonoBehaviour,IInteractable
{
    public bool taken = false;
    public GameObject seed;

    public void Interact()
    {
        taken = true;
        seed.SetActive(false);
    }
}
