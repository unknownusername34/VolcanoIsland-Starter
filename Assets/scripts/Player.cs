using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public int intialHealth = 3;
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = intialHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        float input = Input.GetAxisRaw("Horizontal");
        pos.x = pos.x + input * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x = pos.x - speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x = pos.x + speed * Time.deltaTime;
        }
        
        this.transform.position = pos;
    }

    public void Reset()
    {
        currentHealth = intialHealth;
        Vector3 pos = new Vector3(2.06f, -2.63f, -0.2817f);
    }
}
