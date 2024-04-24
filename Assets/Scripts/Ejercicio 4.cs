using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ejercicio4 : MonoBehaviour
{
    public GameObject coins;
    public Text missionText;
    public Text missionText2;
    int score;
    float spawnRadius = 2f;
    float spawnInterval = 1f;
    float nextSpawn;

    bool missionActive = false;

    private void Start()
    {
        missionActive = false;
    }
    private void Update()
    {
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, 0f); // Asegura que el objeto esté en el mismo plano Z que el mouse
        } // movimiento
        if (missionActive && Time.time >= nextSpawn)
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
        if (collision.gameObject.CompareTag("Start"))
        {
            missionText2.text = "Junta Monedas";
            missionActive = true;
        }
        if (collision.gameObject.CompareTag("stop"))
        {
            missionText2.text = "Mision inactiva";
            missionActive = false;
        }
    }
    private void UpdateScore()
    {
        missionText.text = "coins: " + score;
    }
    private void SpawnObject()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-spawnRadius, spawnRadius), Random.Range(-spawnRadius, spawnRadius), 0f);

        Instantiate(coins, randomPosition, Quaternion.identity);
    }
}
