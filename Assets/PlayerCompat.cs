using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCompat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 20;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            Attack();
        }
        void Attack()
        {
            animator.SetTrigger("Attack");
           Collider2D [] hitEnimies=  Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
            foreach(Collider2D enemy in hitEnimies)
            {
                enemy.GetComponent<Enemy>().takeDamage(attackDamage);
            }
            
        }
        
        void OnDrawGizmosSelected()
        {   if(attackPoint == null)
            {
                return;
            }
            Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        }
        
    }
}
