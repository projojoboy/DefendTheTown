using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HouseController : MonoBehaviour {

    public int healthPoints = 10;
    [SerializeField] Text healthText;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Enemy")
        {
            healthPoints--;
            coll.GetComponent<EnemyController>().DestroyEnemy();
            Debug.Log(healthPoints);
            healthText.text = "Town Health: " + healthPoints;
        }
    }

    private void Update()
    {
        if(healthPoints == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
