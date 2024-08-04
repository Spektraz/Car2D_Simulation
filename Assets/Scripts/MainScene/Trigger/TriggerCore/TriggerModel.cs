using UnityEngine;

namespace MainScene.Trigger.TriggerCore
{
    public abstract class TriggerModel : MonoBehaviour
    {
        [Header("Canvas Win")] 
        [SerializeField] private Canvas m_canvas;
        [Header("Collider Car")] 
        [SerializeField] private Collider2D m_collider;
        [Header("State Game")] 
        [SerializeField] private bool  m_Win;
        public Canvas Canvas => m_canvas;
        public Collider2D Сollider => m_collider;
        public bool Win => m_Win;
    }
}
