using Unity.VisualScripting;
using UnityEngine;

public class SpawnerRato : MonoBehaviour
{
    public GameObject[] spawnersRatoComum;
    public GameObject[] spawnersRatoBravo;
    public GameObject[] spawnersRatoBomzinho;
    public float startingTimer;
    public float timerSpawn;
    void Start()
    {
        startingTimer = 3;
        timerSpawn = startingTimer;
    }

    void Update()
    {
        timerSpawn -= Time.deltaTime;

        if(timerSpawn < 0)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        int randomizador = Random.Range(0, 8);

        int escolherRato = Random.Range(1, 5);
        switch(escolherRato)
        {
            case 1:
                spawnersRatoComum[randomizador].SetActive(true);
                break;

            case 2:
                spawnersRatoComum[randomizador].SetActive(true);
                break;

            case 3:
                spawnersRatoBravo[randomizador].SetActive(true);
                break;

            case 4:
                spawnersRatoBomzinho[randomizador].SetActive(true);
                break;

            case 5:
                spawnersRatoBomzinho[randomizador].SetActive(true);
                break;
        }

        startingTimer = Random.Range(1.2f, 3);
        timerSpawn = startingTimer;
    }
}
