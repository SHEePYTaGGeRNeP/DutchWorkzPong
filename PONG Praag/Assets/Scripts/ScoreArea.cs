using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class ScoreArea : MonoBehaviour
{
    public int Score { get; private set; }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.Score++;
    }
}
