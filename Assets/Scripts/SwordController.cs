using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordController : MonoBehaviour {

    Animator anim;
    [SerializeField] Collider2D swordCollider;

    bool canAttack = true;

    // Use this for initialization
    void Start() {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canAttack)
        {
            Debug.Log("Slash");
            anim.SetTrigger("Slash");
            swordCollider.enabled = true;
            canAttack = false;
        }
    }

    public void AnimStopPlaying()
    {
        Debug.Log("Stopped");
        swordCollider.enabled = false;
        canAttack = true;
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Enemy")
        {
            coll.GetComponent<EnemyController>().DestroyEnemy();
        }
    }
}
