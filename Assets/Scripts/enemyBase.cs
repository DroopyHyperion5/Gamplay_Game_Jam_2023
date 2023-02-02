using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class enemyBase : MonoBehaviour
{
    //public static event Action<enemyBase> OnEnemyKilled;
    [SerializeField] protected float HP, maxHP = 3f;
    [SerializeField] protected float enemySpeed = 5f;
    Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    protected void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    protected void Start()
    {
        HP = maxHP;
        target = GameObject.Find("Player").transform;
    }

    protected void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
    }
    protected void FixedUpdate()
    {
        if(target)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * enemySpeed;
        }
    }

    public void TakeDamage(float damageAmount)
    {
        
    }
}
