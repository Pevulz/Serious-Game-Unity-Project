using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_music : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(audio.clip, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
