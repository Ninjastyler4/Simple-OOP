using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyFast : Enemy
{
    [SerializeField] private float speedMultiplier = 1.5f;
    protected override void Move()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * speedMultiplier);
    }
}
