using Unity.VisualScripting;
using UnityEngine;

public class Rato : MonoBehaviour
{
    public float exitTimer;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite[] sprites;

    private void OnEnable()
    {
        exitTimer = 2.5f;
        spriteRenderer.sprite = sprites[Random.Range(0, 6)];
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
