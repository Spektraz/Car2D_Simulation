using UnityEngine;

namespace System
{
    public static class GlobalConst
    {
        [Header("Scene")] 
        public const string MainScene = "Main";
        [Header("Name pedal")] 
        public const string AccelPedal = "Accel";
        public const string StopPedal = "Stop";
        [Header("Final Game")] 
        public const string Win = "Win";
        public const string Loose = "Loose";
        [Header("Speed")]
        public const int SpeedCar = 150;
        public const int RotationCar = 300;
        public const float FrontSpeed = 1f;
        public const float StopSpeed = -1f;
    }
}
