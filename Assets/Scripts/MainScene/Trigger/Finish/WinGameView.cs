using MainScene.Trigger.TriggerCore;
using UnityEngine;

namespace MainScene.Trigger.Finish
{
    public class WinGameView : TriggerView
    {
        [SerializeField] private WinGameModel m_viewModel = null;
        public override void OnTriggerEnter2D(Collider2D other)
        {
            if (other == m_viewModel.Сollider)
            {
                isWin = m_viewModel.Win;
                m_viewModel.Canvas.enabled = true;
                base.OnTriggerEnter2D(other);
            }
        }
        protected override IController CreateController() => new WinGameController(this);
    }
}