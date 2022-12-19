using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vectorform.DesignPatternCookbook.StatePattern
{
    [RequireComponent(typeof(Image))]
    public class PhotoshopCursor : MonoBehaviour
    {
        private Image _icon;

        void Awake()
        {
            _icon = GetComponent<Image>();
        }

        public void SetIcon(Sprite newIcon)
        {
            _icon.sprite = newIcon;
        }

        void Update()
        {
            transform.position = Input.mousePosition;
        }
    }
}