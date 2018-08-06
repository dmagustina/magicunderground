using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingTowardsEnemyState : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<Enemy>().life <= 0)
            gameObject.GetComponent<EnemyStateManager>().Died();
        else
            transform.position = Vector3.MoveTowards(transform.position, gameObject.GetComponent<Enemy>().target, gameObject.GetComponent<Enemy>().speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("castle"))
        {
            col.GetComponent<Castle>().getAttacked(gameObject.GetComponent<Enemy>().attackForce);
            gameObject.GetComponent<EnemyStateManager>().Died();
        }

    }
}
