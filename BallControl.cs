using UnityEngine;

public class Puck : MonoBehaviour
{
    public float speed = 20f;

    public float limitX = 6f;
    public float limitY = 9f;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ir();
    }

    void FixedUpdate()
    {
        if (rb2d.linearVelocity.magnitude > 0.01f)
        {
            rb2d.linearVelocity = rb2d.linearVelocity.normalized * speed;
        }

        if (Mathf.Abs(transform.position.x) > limitX ||
            Mathf.Abs(transform.position.y) > limitY)
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


