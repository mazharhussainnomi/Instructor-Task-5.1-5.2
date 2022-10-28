using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwnObjects : MonoBehaviour
{

    public GameObject objectsToSpawn;
    public GameObject bulletPrefab;
    public float speed = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectsToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(bulletPrefab);
            //, transform.position, bulletPrefab.transform.rotation);
            // transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
