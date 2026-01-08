using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float zRange = -12f;
    private void Update()
    {
        Action();
        BoundaryLimiter();
    }
    public virtual void Action()
    {
        //Overriding Logic
        Debug.Log("Action Done!");
    }
    private void BoundaryLimiter()
    {
        if (transform.position.z < zRange)
        {
            Debug.Log("limit reached");
            Destroy(gameObject);
        }
    }
}
