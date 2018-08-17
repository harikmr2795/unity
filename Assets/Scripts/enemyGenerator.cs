using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour {

    public GameObject[] enemies;
    public Vector3 nextEnemyPosition;

	void Start () {
        nextEnemyPosition = transform.position;
        nextEnemyPosition.y += 4f;
        CreateEnemy();
        CreateEnemy();
        CreateEnemy();
    }

    void CreateEnemy () {
        var id = Instantiate(enemies[Random.Range(0, 3)], nextEnemyPosition, Quaternion.identity);
        Destroy(id, 5);
        nextEnemyPosition.y += 7f;
    }

    void FixedUpdate()
    {
        if (nextEnemyPosition.y - 10f < cameraAnchor.cameraRb.position.y)
            CreateEnemy();
    }
}
