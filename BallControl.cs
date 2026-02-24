using UnityEngine;

public class Puck : MonoBehaviour
{
    public float speed = 22f;

    public float limX = 6f;
    public float limY = 9f;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ir();
    }

    void FixedUpdate()
    {
        if (rb2d.linearVelocity.magnitude > 0.02f)
        {
            rb2d.linearVelocity = rb2d.linearVelocity.normalized * speed;
        }

        if (Mathf.Abs(transform.position.x) > limX ||
            Mathf.Abs(transform.position.y) > limY)
        {
            retorna();
        }
    }

    void ir()
    {
        Vector2 dir = Random.insideUnitCircle.normalized;
        rb2d.linearVelocity = dir * speed;
    }

    void retorna()
    {
        transform.position = Vector3.zero;
        rb2d.linearVelocity = Vector2.zero;

        Invoke(nameof(ir), 0.5f);
    }
}


