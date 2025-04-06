using System.Collections;
using System.Collections.Generic;
using System.Timers;
using Unity.VisualScripting;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    private PointManager pointManager;
    // Start is called before the first frame update
    void Start()
    {
        RotateLeft();
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.up *moveSpeed* Time.deltaTime);
    }

    void RotateLeft () {
        transform.Rotate (Vector3.forward * -90);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Enemy"){
            Destroy(collision.gameObject);
            pointManager.UpdateScore(50);
            Destroy(gameObject);
        }
    }
}
