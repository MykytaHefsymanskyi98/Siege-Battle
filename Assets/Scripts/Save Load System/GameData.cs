using System;

namespace Save_Load_System
{
    [Serializable]
    public class GameData
    {
        public int languageIndex;
        public bool soundMuted;

        public GameData()
        {
            languageIndex = 0;
            soundMuted = false;
        }
    }
}
