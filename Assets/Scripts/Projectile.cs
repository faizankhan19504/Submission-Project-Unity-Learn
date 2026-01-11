using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Variables Declaration
    private float zRangeLimit = 20f;
    private float movementSpeed = 18f;

    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        DestroyOutofBound();
    }

    // Destroy the Projectile when out of zRangeLimit
    private void DestroyOutofBound()
    {
        if (transform.position.z > zRangeLimit)
        {
            Destroy(gameObject);
        }
    }
}
