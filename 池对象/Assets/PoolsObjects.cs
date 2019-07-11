using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolsObjects : MonoBehaviour {
    public GameObject poolObject;

    public int poolSize=5;

    public List<GameObject > poolObjectsList = new List<GameObject>();

    public Transform spawnPool;

    public GameObject   GetObject()
    {
        for (int i = 0; i < poolObjectsList.Count; i++)
         {
            if (!poolObjectsList [i].activeInHierarchy)
            {
                poolObjectsList[i].SetActive(true);

                poolObjectsList[i].GetComponent<Rigidbody>().velocity =transform .forward * 5;
                return poolObjectsList[i];

            }
        }
        return createPoolObject(poolObject, spawnPool);
    }
	// Use this for initialization
	void Start () {
        for (int i = 0; i < poolSize; i++)
        {
         GameObject go=   createPoolObject(poolObject, spawnPool);

            go.SetActive(false);

        }
    }
	
	// Update is called once per frame
	void Update () {
		if (Input .GetKeyDown (KeyCode .J))
        {
            GetObject();
        }
	}

  public GameObject    createPoolObject(GameObject Poolobject,Transform spawn)
    {
        GameObject go = GameObject.Instantiate(Poolobject);

        go.transform.parent = spawn;
        go.transform.position = spawn.position;
        go.transform.rotation = spawn.rotation;
        go.transform.localScale = new Vector3(1, 1, 1);

        go .GetComponent<Rigidbody>().velocity = transform.forward * 5;

        poolObjectsList.Add(go);

        return go;
    }
    
}
