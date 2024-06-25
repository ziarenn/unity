using UnityEngine;

public class Ground_moving : MonoBehaviour
{
    public float speed = 5f;

    private float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x;
    }
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge-5)
        {
            Destroy(gameObject);
        }
    }

}