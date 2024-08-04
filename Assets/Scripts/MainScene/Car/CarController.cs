using System;
using UnityEngine;

namespace MainScene.Car
{
    public class CarController 
    {
        private CarModel m_viewModel = null;
        private float m_moveInput;
        public CarController(CarModel viewModel)
        {
            m_viewModel = viewModel;
        }
        public void Initialize()
        {
             InitializeEvents();
        }
        public void MoveRigidbody()
        {
          m_viewModel.FrontTireRB.AddTorque(-m_moveInput * m_viewModel.Speed * Time.fixedDeltaTime);  
          m_viewModel.BackTireRB.AddTorque(-m_moveInput * m_viewModel.Speed * Time.fixedDeltaTime);  
          m_viewModel.CarRB.AddTorque(-m_moveInput * m_viewModel.RotationSpeed * Time.fixedDeltaTime);
        }
        
        private void SetSide(string name, bool state)
        {
            if (name == GlobalConst.AccelPedal && state)
            {
                m_moveInput = GlobalConst.FrontSpeed;
            }
            else if(name == GlobalConst.AccelPedal &&!state)
            {
                m_moveInput = 0;
            }
            else if (name == GlobalConst.StopPedal && state)
            {
                m_moveInput = GlobalConst.StopSpeed;
            }
            else if(name == GlobalConst.StopPedal &&!state)
            {
                m_moveInput = 0;
            }
        }
        private void InitializeEvents()
        {
            ApplicationContainer.Instance.EventHolder.OnButtonPressEvent += SetSide;
        }
        private void DisposeEvents()
        {
            ApplicationContainer.Instance.EventHolder.OnButtonPressEvent -= SetSide;
        }
        public void Dispose()
        {
             DisposeEvents();
        }
    }
}
