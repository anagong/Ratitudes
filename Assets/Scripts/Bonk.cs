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
    
    [Header("HUD")]
    public TextMeshProUGUI tmpontos;
    public TextMeshProUGUI tmBonks;
    private int bonks;

    [Header("rato bravo grr")]
    public RatoBravo ratoBravo;

    void Start()
    {

    }

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
                        bonks++;
                    }

                    if (hit.gameObject.CompareTag("RatoBravo"))
                    {
                        ratoBravo = hit.gameObject.GetComponent<RatoBravo>();
                        bonks++;
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

        tmBonks.text = bonks + " acertos";
        tmpontos.text = "Pts: " + pontos;
        if(pontos >= 3000)
        {
            SceneManager.LoadScene(3);
        }
    }
}