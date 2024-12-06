using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Player.isAlive = true;
            Spawner.globalSpeedMultiplier = 1.0f;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}
