using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BezierMovement(new Vector3(5,0.65f,0), new Vector3(0,2,0)));
    }
    IEnumerator BezierMovement(Vector3 to, Vector3 extraPos)
    {
        Vector3 startPosition = transform.position;
        float t = 0.0f;
        while (t < 1.0f)
        {
            transform.position = BezierInterpolation.QuadraticBezier(startPosition, to, extraPos, t);
            t += Time.deltaTime * speed;
            yield return null;
        }
        transform.position = to;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
