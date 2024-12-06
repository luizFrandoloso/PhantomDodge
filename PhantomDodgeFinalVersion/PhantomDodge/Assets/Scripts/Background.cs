using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{


    public float speed;
    public float Xend;
    public float Xstart;

    private void Update()
    {
        if (!Player.isAlive) return; // Pausa o movimento se o jogador estiver morto

        transform.Translate(Vector2.left * speed * Spawner.globalSpeedMultiplier * Time.deltaTime);

        if (transform.position.x < Xend)
        {
            Vector2 pos = new Vector2(Xstart, transform.position.y);
            transform.position = pos;
        }
    }
}