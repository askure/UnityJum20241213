using Battle;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Result
{
    public class View : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _test = null;

        public static View Create()
        {
           
            var prefab = Resources.Load<View>("Prefab/result_ui");
            var canvasRoot = GameObject.Find("Canvas").transform;
            var view = Instantiate(prefab, canvasRoot);
            view.SetUp();
            return view;
        }

        private void SetUp()
        {
            _test.text = Battle.Manager.isClear ? "‚­‚è‚ " : "‚Ü‚¯";
        }


    }
}

