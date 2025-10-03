using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RatoBom : MonoBehaviour
{
    private float exitTimer;

    private void OnEnable()
    {
        exitTimer = 3.5f;
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
    }

    void Fugiu()
    {
        gameObject.SetActive(false);
    }
}
