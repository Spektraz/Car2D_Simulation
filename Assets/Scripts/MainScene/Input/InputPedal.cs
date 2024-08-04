using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MainScene.Input
{
    public class InputPedal : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private string m_nameButton;
        private bool m_buttonPressed;

        public void OnPointerDown(PointerEventData eventData)
        {
            m_buttonPressed = true;
            Result();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            m_buttonPressed = false;
            Result();
        }

        private void Result()
        {
            ApplicationContainer.Instance.EventHolder.OnButtonPress(m_nameButton, m_buttonPressed);
        }
    }
}