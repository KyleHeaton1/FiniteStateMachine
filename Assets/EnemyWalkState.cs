using UnityEngine;

public class EnemyWalkState : EnemyBaseState
{
    float timer;
    float speed = 5;
    int randNum;
    Rigidbody2D rb;

    public override void EnterState(EnemyStateManager enemy)
    {
        Debug.Log("Walking");
        timer = .5f;
        rb = enemy.GetComponent<Rigidbody2D>();
        randNum = Random.Range(1, 3);
    }

    public override void UpdateState(EnemyStateManager enemy)
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            enemy.SwitchState(enemy.IdleState);
        }

        if(randNum == 1)
        {
            rb.velocity = new Vector2(speed, 0);
        }else
        {
            rb.velocity = new Vector2(-speed, 0);
        }


    }

    public override void OnCollisionEnter2D(EnemyStateManager enemy, Collision2D collsion)
    {

    }
}
