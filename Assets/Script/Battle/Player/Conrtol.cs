using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle.Player{
    public class Conrtol : MonoBehaviour
    {
        float _posX;
        float _posY;
        public float GetPosX => _posX;
        public float GetPosY => _posY;

        void Start ()
        {
            _posX = transform.position.x;
            _posY = transform.position.y;
        }

        // Update is called once per frame
        void Update()
        {
            // ないとは思うけど動いたときように毎フレーム更新
            _posX = transform.position.x;
            _posY = transform.position.y;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Debug.Log("OnCollisionEnter2D");
            if (collision.gameObject.CompareTag(Sys.Tag.EnemyTag))
            {
                Manager.GameOver();
                Debug.Log("Enemy Enter in Player");

            }
        }


    }
}

