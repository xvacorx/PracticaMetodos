using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectilePrefab;
    float fireRate = 1f;
    public float projectileSpeed = 10f;

    private float nextFireTime;
    private void Start()
    {
        nextFireTime = Time.time;
    }
    private void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shootDirection = (mousePosition - transform.position).normalized;
        transform.up = shootDirection;

        if (Input.GetMouseButton(0) && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
    private void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();

        rb.velocity = transform.up * projectileSpeed;
        Destroy(projectile, 5f);
    }
}