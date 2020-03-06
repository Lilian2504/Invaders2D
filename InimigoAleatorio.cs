using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoAleatorio : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    public float intialDelay;
    public float enemyPeriod;
    public float enemyHeight;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("CreateEnemy",intialDelay,enemyPeriod);
    }

    void CreateEnemy()
    {
        float a = Random.Range(-enemyHeight,enemyHeight);
        var enemyTransform = Instantiate(enemyPrefab,this.gameObject.transform).transform;
        enemyTransform.position += a*Vector3.up;
    }

}
