using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        RotateRight();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    

    void RotateRight () {
        transform.Rotate (Vector3.forward * 90);
    }
}
