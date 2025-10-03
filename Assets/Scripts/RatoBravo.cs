using Unity.VisualScripting;
using UnityEngine;

public class RatoBravo : MonoBehaviour
{
    public float exitTimer;
    public int vida;

    private void OnEnable()
    {
        exitTimer = 3.5f;
        vida = 2;
    }

    private void Start()
    {

    }

    private void Update()
    {
        exitTimer -= Time.deltaTime;
        if (exitTimer <= 0)
        {
            Fugiu();
        }

        if (vida == 0)
        {
            gameObject.SetActive(false);
        }
    }

    void Fugiu()
    {
        gameObject.SetActive(false);
    }
}
