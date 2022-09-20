using UnityEngine;

public class EnemyIdleState : EnemyBaseState
{
    float timer;
    Rigidbody2D rb;

    public override void EnterState(EnemyStateManager enemy)
    {
        Debug.Log("Idle");
        timer = 1.5f;
        rb = enemy.GetComponent<Rigidbody2D>();
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            enemy.SwitchState(enemy.WalkState);
        }

        
    }

    public override void OnCollisionEnter2D(EnemyStateManager enemy, Collision2D collsion)
    {

    }
}
