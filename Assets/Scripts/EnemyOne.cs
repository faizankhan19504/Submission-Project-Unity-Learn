using UnityEngine;

public class EnemyOne : Enemy
{
    private float enemySpeed = 1f;
    public override void Action()
    {
        transform.Translate(Vector3.back * Time.deltaTime * enemySpeed);
    }
}
