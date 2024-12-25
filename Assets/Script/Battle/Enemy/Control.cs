using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle.Enemy
{
    public class Control : MonoBehaviour
    {
        // Start is called before the first frame update
        private Player.Conrtol _playerControl;
        private int _beforeTime;
        private int speed = 5;
        private float distanseX;
        private float distanseY;

        void Start()
        {
            _beforeTime = 0;
        }

        // Update is called once per frame
        void Update()
        {
            var x = transform.position.x + distanseX / speed / Application.targetFrameRate * Manager.Time;

            var y = transform.position.y + distanseY / speed / Application.targetFrameRate * Manager.Time;
            transform.position = new Vector3(x, y, 0);
        }
        public void GetPlayer(Player.Conrtol control)
        {
            _playerControl = control;
            distanseX = _playerControl.GetPosX - transform.position.x;
            distanseY = _playerControl.GetPosY - transform.position.y;
            Debug.Log($"({distanseX},{distanseY})");
        }

        public void Dead()
        {
            Destroy(gameObject);
        }
    }
}

