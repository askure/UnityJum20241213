using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Battle.Enemy
{
    public class View : MonoBehaviour
    {
        [SerializeField] SpriteRenderer icon = null;
        public static View Create(Sprite icon, Transform pos = null)
        {
            var prefab = Resources.Load<View>("Prefab/enemy");
            pos = GameObject.Find("enemy_root_right").transform;
            var view = Instantiate(prefab, pos);
            view.SetUp(icon);
            return view;
        }
        private void SetUp(Sprite icon)
        {
            //this.icon.sprite = icon;
        }
    }


}
