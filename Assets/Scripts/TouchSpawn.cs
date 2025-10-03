using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

public class TouchSpawn : MonoBehaviour
{

    public GameObject[] objects;
    private int index;
    private AudioSource audioSource;
    public AudioClip clip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        index = 0;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
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

    // Baka mitai kodomo nano ne
    // Yume wo otte kizutsuite
    // Uso ga heta na kuse ni waraenai egao wo miseta
    // I love you moroku ni iwanai
    // Kuchi-ben de hontō ni bukiyō
    // Na no ni na no ni dōshite sayonara wa ieta no
    // Dame da ne
    // Dame yo dame na no yo
}
