using UnityEngine;

namespace MainScene.Car
{
    public class CarView : MonoBehaviour
    {
        [SerializeField] private CarModel m_viewModel = null;
        private CarController m_controller = null;

        private void Start()
        {
            m_controller = new CarController(m_viewModel);
            m_controller.Initialize();
        }
        private void FixedUpdate()
        {
            m_controller.MoveRigidbody();
        }

        private void OnDestroy()
        {
            m_controller.Dispose();
        }
    }
}
