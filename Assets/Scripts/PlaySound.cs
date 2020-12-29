using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip clip;

    void Start()
    {
        GameObject tempGO = new GameObject("TempAudio");
        tempGO.transform.position = gameObject.transform.position;
        AudioSource aSource = tempGO.AddComponent<AudioSource>();
        aSource.clip = clip;
        aSource.spatialBlend = 0;
        aSource.playOnAwake = false;
        aSource.Play();
        Destroy(tempGO, clip.length);
    }
}
