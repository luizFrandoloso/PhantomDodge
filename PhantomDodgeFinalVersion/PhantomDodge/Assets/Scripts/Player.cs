using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static bool isAlive = true;

    public float speed;
    public float increment;
    public float maxY;
    public float minY;

    private Vector2 targetPos;

    public int health;

    public GameObject moveEffect;
    public Animator camAnim;

    public GameObject spawner;
    public GameObject restartDisplay;

    public GameObject explosionSound;
    public GameObject moveSound;

    // Referências aos fantasminhas
    public GameObject[] vida; // Array para armazenar os fantasminhas na UI

    private void Update()
    {
        if (health <= 0)
        {
            isAlive = false;
            spawner.SetActive(false);
            restartDisplay.SetActive(true);
            Destroy(gameObject);
            Instantiate(moveSound, transform.position, Quaternion.identity);
        }

        // Atualiza os fantasminhas na UI
        Updatevida();

        // Movimento do jogador
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Spawner.globalSpeedMultiplier * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxY)
        {
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + increment);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minY)
        {
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - increment);
        }
    }

    // Método para atualizar as imagens da vida
    private void Updatevida()
    {
        for (int i = 0; i < vida.Length; i++)
        {
            if (i < health)
            {
                vida[i].SetActive(true); // Mostra a vida
            }
            else
            {
                vida[i].SetActive(false); // Oculta a vida
            }
        }
    }
}
