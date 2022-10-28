using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    public float speed = 500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
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
