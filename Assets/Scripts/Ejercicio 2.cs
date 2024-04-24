using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio2 : MonoBehaviour
{
    public GameObject coins;
    public Text scoreText;
    int score;
    float spawnRadius = 3f;
    float spawnInterval = 3f;
    float nextSpawn;
    private void Update()
    {
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0f); // Asegura que el objeto esté en el mismo plano Z que el mouse
        } // movimiento
        if (Time.time >= nextSpawn)
        {
            SpawnObject();
            nextSpawn = Time.time + spawnInterval;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            score++;
            UpdateScore();
        }
    }
    private void UpdateScore()
    {
        scoreText.text = "score: " + score;
    }
    private void SpawnObject()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-spawnRadius, spawnRadius), Random.Range(-spawnRadius, spawnRadius), 0f);

        Instantiate(coins, randomPosition, Quaternion.identity);
    }
}