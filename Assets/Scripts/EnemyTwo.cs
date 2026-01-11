using UnityEngine;

public class EnemyTwo : Enemy
{
    // Variables Declaration
    private float moveSpeed = 5f;
    private float rotationSpeed = 200f;

    // We use 'override' to replace the empty Action() function in the base Enemy script
    // with this specific movement logic.
    public override void Action()
    {
        // 1. MOVE: Move forward in world space (so it doesn't spiral)
        // Use Space.World to move in a straight line regardless of the spin
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime, Space.World);

        // 2. ROTATE: Spin around its own Y-axis
        // Space.Self ensures it rotates around its own center
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.Self);
    }
}
