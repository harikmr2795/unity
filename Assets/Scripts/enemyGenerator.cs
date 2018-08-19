using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour {

    public GameObject[] enemies;
    public Vector3 nextEnemyPosition;
    public GameObject lastCreatedObject;
    public List<GameObject> allCreatedObjects;

    void Start () {
        allCreatedObjects = new List<GameObject>();
        nextEnemyPosition = transform.position;
        nextEnemyPosition.y += 4f;
        CreateEnemy(false);
        CreateEnemy(false);
        CreateEnemy(false);
        CreateEnemy(false);
    }

    void CreateEnemy (bool destroy) { //destroys an old object if passed value true
        lastCreatedObject = Instantiate(enemies[Random.Range(0, 3)], nextEnemyPosition, Quaternion.identity);
        allCreatedObjects.Add(lastCreatedObject);
        if (destroy)
        {
            Destroy(allCreatedObjects[0], 0);
            allCreatedObjects.RemoveAt(0);
        }
        nextEnemyPosition.y += 7f;
    }

    void FixedUpdate()
    {
        if (nextEnemyPosition.y - 15f < cameraAnchor.cameraRb.position.y)
            CreateEnemy(true);
    }
}
