using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle.Shield 
{
    public class Conrtrol : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("OnCollisionEnter2D");
            if (collision.gameObject.CompareTag(Sys.Tag.EnemyTag))
            {
                var enemy = collision.gameObject.GetComponent<Enemy.Control>();
                enemy.Dead();
                Debug.Log("Enemy Enter in Shield");

            }
        }
    }
}

