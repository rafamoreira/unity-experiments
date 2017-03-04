using UnityEngine;

public static class HexMetrics{

    public const float outerRadius = 10f;

    public const float innerRadius = outerRadius * 0.866025404f;

    public static Vector3[] corners =
    {
        new Vector3(0, 0, outerRadius),
        new Vector3(innerRadius, 0, 0.5f * outerRadius),
        new Vector3(innerRadius, 0, -0.5f * outerRadius),
        new Vector3(0, 0, -outerRadius),
        new Vector3(-innerRadius, 0, -0.5f * outerRadius),
        new Vector3(-innerRadius, 0, 0.5f * outerRadius)
    };
}
