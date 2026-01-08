using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float zRangeLimit = 20f;
    private float movementSpeed = 18f;
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        DestroyOutofBound();
    }
    private void DestroyOutofBound()
    {
        if (transform.position.z > zRangeLimit)
        {
            Destroy(gameObject);
        }
    }
}
