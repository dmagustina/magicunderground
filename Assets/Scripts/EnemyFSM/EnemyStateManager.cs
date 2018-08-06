
using UnityEngine;

public class EnemyStateManager : MonoBehaviour {

    private MonoBehaviour state;
    public Animator anim;

    // Use this for initialization
    void Start()
    {
        state = gameObject.AddComponent<WalkingTowardsEnemyState>();

    }

    public void GetsHurt(float damage)
    {
        Destroy(state);
        anim.SetTrigger("Damage");
        state = gameObject.AddComponent<GettingHurtEnemyState>();

        ((GettingHurtEnemyState)state).SetDamage(damage);
    }

    public void Died()
    {
        Destroy(state);
        state = gameObject.AddComponent<DyingEnemyState>();
    }

    internal void KeepWalking()
    {
        Destroy(state);
        anim.SetTrigger("Walk");
        state = gameObject.AddComponent<WalkingTowardsEnemyState>();
    }
}
