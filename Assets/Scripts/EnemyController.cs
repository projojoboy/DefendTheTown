using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    private GameObject house;
    private Vector3 housePos;
    [SerializeField] private float speed;

	// Use this for initialization
	void Start () {
        house = GameObject.FindGameObjectWithTag("House");

        housePos = house.transform.position;

	}

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, housePos, speed * Time.deltaTime);
    }

    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }


}
