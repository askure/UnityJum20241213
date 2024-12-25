using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

namespace Battle
{
    public class UiView : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] TextMeshProUGUI _txtsuervive_value = null;

        public class ViewData
        {

            public int Survive;

            public ViewData(int survive)
            {
                this.Survive = survive;
            }
        }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
        }

        public static UiView Create(ViewData viewData)
        {   
            // UIê∂ê¨Ç∆PlayerÇÃViewÇóºï˚Ç‚ÇÈ
            var prefab = Resources.Load<UiView>("Prefab/battle_ui");
            var canvasRoot = GameObject.Find("Canvas").transform;
            var view = Instantiate(prefab, canvasRoot);
            view.SetUpUi(viewData);
            return view;
        }
        private void SetUpUi(ViewData vIewData)
        {
            _txtsuervive_value.text = Sys.Text.SurviveValue(vIewData.Survive);
        }

        public void UpdateSurvive(int survive)
        {
            _txtsuervive_value.text = survive.ToString();
        }
    }
}

