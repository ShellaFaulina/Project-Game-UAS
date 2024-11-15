using UnityEngine;

public static class Extensions
{
    public static LayerMask layerMask = LayerMask.GetMask("Default");
    public static bool Raycast(this Rigidbody2D rb2D, Vector2 direction)
    {
        if (rb2D.isKinematic) {
            return false;
        }

        float radius = 0.25f;
        float distance = 0.415f;

        RaycastHit2D hit = Physics2D.CircleCast(rb2D.position, radius, direction, distance, layerMask);
        return hit.collider != null && hit.rigidbody != rb2D;
    }

    public static bool DotTest(this Transform transform, Transform other, Vector2 testDirection)
    {
        Vector2 direction = other.position - transform.position;
        return Vector2.Dot(direction.normalized, testDirection) > 0.25f;
    }

}
