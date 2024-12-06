using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float speed;
    public GameObject effect;

    public GameObject explosionSound;

    void Update()
    {
        // Aumentar a velocidade multiplicando pelo modificador global.
        transform.Translate(Vector2.left * speed * Spawner.globalSpeedMultiplier * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(explosionSound, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health--;
            other.GetComponent<Player>().camAnim.SetTrigger("shake");
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
