using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepGenerator : MonoBehaviour
{
    public GameObject Sheep;

    //Positions where the sheep can spawn
    Random rnd = new Random();
    float pos1 = -15.8f;
    float pos2 = 0.5f;
    float pos3 = 16.3f;

    public float spawnTime = 0.5f;
    float measureTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        measureTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        var num = Random.Range(1, 4);
        if(Time.time - measureTime > spawnTime)
        {
            Shoot(num);
            measureTime = Time.time;
        }
    }

    void Shoot(int num)
    {
        if (num == 1)
        {
            Instantiate(Sheep, new Vector3(pos1, 1, transform.position.z), Quaternion.identity, transform);
        }
        else if (num == 2)
        {
            Instantiate(Sheep, new Vector3(pos2, 1, transform.position.z), Quaternion.identity, transform);
        }
        else
        {
            Instantiate(Sheep, new Vector3(pos3, 1, transform.position.z), Quaternion.identity, transform);
        }
    }
}
