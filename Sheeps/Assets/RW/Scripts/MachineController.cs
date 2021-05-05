using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineController : MonoBehaviour
{
    public float velocity = 1;

    public GameObject hayShootObject;
    public float thresholdShot = 0.5f;
    float measureTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        measureTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float inputKeyValue = Input.GetAxis("Horizontal");
        Vector3 position = transform.position;

        if(inputKeyValue > 0 && position.x < 21)
        {
            transform.Translate(Vector3.right * velocity * Time.deltaTime);
        }

        if(inputKeyValue < 0 && position.x > -21)
        {
            transform.Translate(Vector3.left * velocity * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && (Time.time - measureTime) > thresholdShot){
            Shoot(position);
            measureTime = Time.time;
        }

    }

    void Shoot(Vector3 position)
    {
        Instantiate(hayShootObject, new Vector3(position.x, 1, position.z), Quaternion.identity);
    }

}
