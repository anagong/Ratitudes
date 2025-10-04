using UnityEngine;

public class SomDerrota : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }

    void Update()
    {
        
    }
}
