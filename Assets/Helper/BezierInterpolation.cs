using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierInterpolation 
{
    public static float QuadraticBezier(float a, float b, float p, float t)
    {
        if (t <= 0)
            return a;
        else if (t >= 1)
            return b;

        float st = t * t;
        return a + 2 * p * t - 2 * a * t + b * st - 2 * p * st + a * st;
    }

    public static Vector3 QuadraticBezier(Vector3 a, Vector3 b,  Vector3 p,  float t)
    {
        if (t <= 0)
            return a;
        else if (t >= 1)
            return b;

        return new Vector3(
          QuadraticBezier(a.x, b.x, p.x, t),
          QuadraticBezier(a.y, b.y, p.y, t),
          QuadraticBezier(a.z, b.z, p.z, t));
    }
}
