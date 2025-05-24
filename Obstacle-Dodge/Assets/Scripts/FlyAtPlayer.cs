using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, moveSpeed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
            Destroy(gameObject);
    }
}
