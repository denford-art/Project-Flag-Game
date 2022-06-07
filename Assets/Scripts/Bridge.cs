using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Bridge : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Hero.Instance.gameObject)
        {
            GetComponent<Animator>().SetTrigger("Open");
        }
    }
}
