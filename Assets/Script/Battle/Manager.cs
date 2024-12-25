using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Battle
{   
    /// <summary>
    /// タイマや操作系を監視する
    /// </summary>
    public class Manager : MonoBehaviour
    {
        // Start is called before the first frame update
        public static string SceneName = "Battle";
        public static bool isClear;
        Control control = null;
        System.Action[] actions;
        private const int LEFTIDX = 0;
        private const int RIGHTIDX = 1;
        private const int UPIDX = 2;
        private const int UNDERIDX = 3;
        public static float Time;
        [SerializeField] Transform player;
        
        void Awake()
        {
            control = new Control(player);
            Time = 0;
            Application.targetFrameRate = 60;
            isClear = false;
        }

        // Update is called once per frame
        void Update()
        {
            // ゲーム設計がWASD移動なのでこれで
            Time += UnityEngine.Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("W");
                ExcuteAction(UPIDX);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("A");
                ExcuteAction(LEFTIDX);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Debug.Log("S");
                ExcuteAction(UNDERIDX);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Debug.Log("D");
                ExcuteAction(RIGHTIDX);
            }
        }

        private void ExcuteAction(int actionIdx)
        {
           for(int i = 0; i < control.GetActions().Length; i++)
            {
                bool active = i == actionIdx;
                control.GetActions()[i](active);
                
            }
        }

        public static void GameOver()
        {
            isClear = false;
            Sys.Scene.ChangeScene(Result.Manager.SceneName);
        }

        public static void GameClear()
        {
            isClear =true;
            Sys.Scene.ChangeScene(Result.Manager.SceneName);
        }
    }
}

