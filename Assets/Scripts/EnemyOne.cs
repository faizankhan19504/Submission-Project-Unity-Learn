using UnityEngine;

public class EnemyOne : Enemy
{
    private float moveSpeed = 1f;
    public override void Action()
    {
        transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
    }
}
