using UnityEngine;

public class EnemyTwo : Enemy
{
    // Variables Declaration
    private float moveSpeed = 5f;
    private float rotationSpeed = 200f;

    // We use 'override' to replace the empty Action() function in the base Enemy script
    // with this specific enemy logic.
    public override void Action()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
