using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class TouchSpawn : MonoBehaviour
{

    public GameObject[] objects;
    private int index;
    private AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {
        index = 0;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == UnityEngine.TouchPhase.Began)
            {
                Vector2 position = Camera.main.ScreenToWorldPoint(touch.position);

                Collider2D hit = Physics2D.OverlapPoint(position);

                if(hit != null)
                {
                    //Tocar o Som
                    if(clip != null)
                    {
                        audioSource.PlayOneShot(clip);
                    }
                    Destroy(hit.gameObject);
                }

                Instantiate(objects[index], position, Quaternion.identity);

                index = (index + 1) % objects.Length;
            }
        }
    }
}
