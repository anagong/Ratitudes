using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;
using TMPro;
using UnityEngine.SceneManagement;

public class Bonk : MonoBehaviour
{
    private int pontos;
    public GameObject martelo;
    public TextMeshProUGUI tmp;
    public RatoBravo ratoBravo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == UnityEngine.TouchPhase.Began)
            {
                Vector2 position = Camera.main.ScreenToWorldPoint(touch.position);

                Collider2D hit = Physics2D.OverlapPoint(position);

                if (hit != null)
                {
                    if (hit.gameObject.CompareTag("RatoComum"))
                    {
                        pontos += 150;
                        hit.gameObject.SetActive(false);
                    }

                    if (hit.gameObject.CompareTag("RatoBravo"))
                    {
                        ratoBravo = hit.gameObject.GetComponent<RatoBravo>();
                        ratoBravo.vida--;
                        if(ratoBravo.vida == 0)
                        {
                            pontos += 300;
                        }
                    }

                    if (hit.gameObject.CompareTag("RatoBom"))
                    {
                        SceneManager.LoadScene(2);
                    }
                }

                Instantiate(martelo, position, Quaternion.identity);
            }
        }

        tmp.text = "Pts: " + pontos;
    }
}