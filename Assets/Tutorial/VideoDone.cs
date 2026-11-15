using UnityEngine;
using UnityEngine.Video;
using System.Collections;

public class VideoDone : MonoBehaviour
{
    public GameObject videoPlayer;
    void Start()
        {
            StartCoroutine(DoAfterDelay(27f));
        }
    
        IEnumerator DoAfterDelay(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            Debug.Log("27 seconds passed!");
            Destroy(videoPlayer);
        }

}