using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour {

    public GameObject[] enemies;
    public Vector3 nextEnemyPosition;

	void Start () {
        nextEnemyPosition = transform.position;
        CreateEnemy();
        CreateEnemy();
        CreateEnemy();
    }

    void CreateEnemy () {
        nextEnemyPosition.y += 7f;
        Instantiate(enemies[Random.Range(0, 2)], nextEnemyPosition, Quaternion.identity);
    }

    void Update()
    {
        if (nextEnemyPosition.y - 10f < cameraAnchor.rb.position.y)
            CreateEnemy();
    }
}
