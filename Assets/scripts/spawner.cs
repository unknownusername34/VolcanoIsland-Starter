using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject Enemy;

    public float spawnTime;
    private float timer;

    public int enemyCount;
    public float burstTimer;
    private float timeUntilBurst;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
        timeUntilBurst = burstTimer;

    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            spawnOne();

            timer += spawnTime;
        }
        else
        {
            timer -= Time.deltaTime;
        }


        if (timeUntilBurst <= 0)
        {
            for(int i = 0; i < enemyCount; i++)
            {
                spawnOne();
            }


            timeUntilBurst = burstTimer;
        }
        else
        {
            timeUntilBurst -= Time.deltaTime;
        }
    }


    public void spawnOne()
    {
        float xpos = Random.Range(-13.62f, 12.71f);
        float ypos = 6f;
        Vector3 pos = new Vector3(xpos, ypos, 0f);

        Instantiate(Enemy, pos, Quaternion.identity);
    }
}
