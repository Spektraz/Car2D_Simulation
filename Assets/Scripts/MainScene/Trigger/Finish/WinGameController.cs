using System;
using MainScene.Trigger.TriggerCore;

namespace MainScene.Trigger.Finish
{
    public class WinGameController :  TriggerController<WinGameView>
    {
        private WinGameModel m_viewModel = null;
        public WinGameController(WinGameView view) : base(view)
        {
        }
        public override void TriggerEnter()
        {
            if(View.isWin)
              ApplicationContainer.Instance.EventHolder.OnFinishGame(GlobalConst.Win);
            if(!View.isWin)
              ApplicationContainer.Instance.EventHolder.OnFinishGame(GlobalConst.Loose);
        }
    }
}

