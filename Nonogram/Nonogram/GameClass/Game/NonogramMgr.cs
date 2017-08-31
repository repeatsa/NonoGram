namespace Nonogram
{
    class NonogramMgr
    {
        private NonogramMgr(){}

        private static NonogramMgr m_GameMgr = null;
        private GridMgr m_GridMgr = null;
        private bool m_bGameStart = false; 

        public static NonogramMgr Instance()
        {
            if (m_GameMgr == null)
            {
                m_GameMgr = new NonogramMgr();
                init();
            }
            return m_GameMgr;
        }

        public bool startGame(IGameFormat _IGameFormat)
        {
            if (_IGameFormat == null)
            {
                return false;
            }
            return true;
        }

        public bool enterKey(IEnterFormat _IEnterFormat)
        {
            if (!m_bGameStart || _IEnterFormat == null)
            {
                return false;
            }
            return true;
        }

        public bool closeGame()
        {
            m_GameMgr = null;
            return true;
        }

        private void init()
        {
           
            m_GridMgr = null;
        }
    }
}
