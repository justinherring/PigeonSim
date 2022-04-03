using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject playerObj;
    Transform playerPos;
    public PlayerController pc;
    public float moveSpeed = 1.3f;

    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;

    Rigidbody2D rb;
    List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = playerObj.transform;
    }

    // called so many times a second; used for physics stuff
    private void FixedUpdate()
    {
        Vector3 direction = (playerObj.transform.position - transform.position);
        Vector2 dir = new Vector2(direction.x, direction.y).normalized;

        if (dir != Vector2.zero)
        {
            rb.MovePosition(rb.position + dir * moveSpeed * Time.fixedDeltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            pc.Defeated();
        }
    }
}
