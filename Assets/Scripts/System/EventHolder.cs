namespace System
{
    public class EventHolder 
    {
        public Action<string> OnFinishGameEvent;
        public void OnFinishGame(string state)
        {
            var temp = OnFinishGameEvent;
            temp?.Invoke(state);
        }
        public Action<string, bool> OnButtonPressEvent;
        public void OnButtonPress(string name, bool state)
        {
            var temp = OnButtonPressEvent;
            temp?.Invoke(name,state);
        }
        public Action OnFrontEvent;
        public void OnFront()
        {
            var temp = OnFrontEvent;
            temp?.Invoke();
        }
        public Action OnStopEvent;
        public void OnStop()
        {
            var temp = OnStopEvent;
            temp?.Invoke();
        }
    }
}
