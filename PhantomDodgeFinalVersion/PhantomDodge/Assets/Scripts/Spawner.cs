using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public static float globalSpeedMultiplier = Mathf.Clamp(globalSpeedMultiplier, 1.0f, 2.0f); //Limitei  para não ficar impossível para o usuário.
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public float timeDecrease;
    public float minTime;

    public GameObject[] obstacleTemplate;

    private void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }



    private void Update()
    {
        globalSpeedMultiplier += 0.05f * Time.deltaTime;

        if (timeBtwSpawns <= 0)
        {
            int rand = Random.Range(0, obstacleTemplate.Length);
            Instantiate(obstacleTemplate[rand], transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;

            // Aumentar a dificuldade reduzindo o tempo entre os spawns
            if (startTimeBtwSpawns > minTime)
            {
                startTimeBtwSpawns -= timeDecrease * Time.deltaTime;
            }
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

}
