using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : Entity
{
    [SerializeField] private List<Transform> points;
    [SerializeField] private float speed;

    private int currentIndex;
    private Vector2 currentPoint;
    private bool walking;

    private void Start()
    {
        lives = 3;
        currentPoint = points[0].position;
        ChooseDirection();
        walking = true;
    }

    void Update()
    {
        Walk();
    }

    private void Walk()
    {
        if (walking)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, currentPoint, step);

            if (Vector3.Distance(transform.position, currentPoint) < 0.3f)
            {
                StartCoroutine(Idle());
            }
        }
    }

    private IEnumerator Idle()
    {
        walking = false;
        ChooseNextPoint();

        yield return new WaitForSeconds(1);

        walking = true;
    }

    private void ChooseNextPoint()
    {
        currentIndex = ++currentIndex < points.Count ? currentIndex : 0;
        currentPoint = points[currentIndex].position;

        ChooseDirection();
    }

    private void ChooseDirection()
    {
        GetComponent<SpriteRenderer>().flipX = currentPoint.x < transform.position.x;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject)
        {
            Hero.Instance.GetDamage();
            lives--;
            Debug.Log("У бревна " + lives);
        }

        if (lives < 1)
            Die();
    }
}
