using UnityEngine;

public class Martelo : MonoBehaviour
{
    private float timerMartelo = 0.35f;

    void Update()
    {
        timerMartelo -= Time.deltaTime;

        if(timerMartelo < 0)
        {
            Destroy(gameObject);
        }
    }
}