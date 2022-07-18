using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int damage;
    public float minSpeed;
    public float maxSpeed;

    private float actualSpeed;
    // Start is called before the first frame update
    void Start()
    {
        actualSpeed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down*actualSpeed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "floor")
        {
            Destroy(this.gameObject);
        }
        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
