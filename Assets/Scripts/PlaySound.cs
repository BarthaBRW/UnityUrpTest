using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip clip;

    public bool is3D = false;

    void Start()
    {
        GameObject tempGO = new GameObject("TempAudio");
        tempGO.transform.position = gameObject.transform.position;
        AudioSource aSource = tempGO.AddComponent<AudioSource>();
        aSource.clip = clip;
        aSource.spatialBlend = is3D ? 1 : 0;
        aSource.playOnAwake = false;
        aSource.Play();
        Destroy(tempGO, clip.length);
    }
}
