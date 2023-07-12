using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpArrow : MonoBehaviour
{
    public float speed = 5f;

    private Player player;
    private Enemy_01 enemy_01;

    private bool isInsideBox = false;

    private void Start()
    {
        player = FindObjectOfType<Player>();
        enemy_01 = FindObjectOfType<Enemy_01>();

        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            isInsideBox = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            isInsideBox = false;
        }
    }

    private void Update()
    {
        if (isInsideBox && Input.GetKeyDown(KeyCode.UpArrow))
        {
            Collider2D itemCollider = GetComponent<Collider2D>();
            Collider2D boxCollider = GameObject.FindGameObjectWithTag("Box").GetComponent<Collider2D>();

            if (boxCollider.bounds.Contains(itemCollider.bounds.min) && boxCollider.bounds.Contains(itemCollider.bounds.max))
            {
                player.L_Attack(25);

                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
