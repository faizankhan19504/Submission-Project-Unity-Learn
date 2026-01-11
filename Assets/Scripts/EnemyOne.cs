using UnityEngine;

public class EnemyOne : Enemy
{
    // Variable Declare
    private float enemySpeed = 1f;

    // We use 'override' to replace the empty Action() function in the base Enemy script
    // with this specific movement logic.
    public override void Action()
    {
        transform.Translate(Vector3.back * Time.deltaTime * enemySpeed);
    }
}
