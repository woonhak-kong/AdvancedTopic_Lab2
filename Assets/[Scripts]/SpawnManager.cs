using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject prefab;
    public GameObject from;
    public GameObject to;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            Instantiate(prefab, new Vector3(from.transform.position.x, from.transform.position.y,0), Quaternion.identity);
        }
        
    }
}
