
namespace Nonogram
{
    class GridMgr
    {
        private GridData[] m_ArrGuideData = null;
        private bool m_bInit = false;

        public void init(int _iCount)
        {
            if (0 > _iCount) return;
            m_ArrGuideData = new GridData[_iCount];
            m_bInit = true;
        }

        public void enterKey(int _iIndex)
        {
            if (!m_bInit) return;
            m_ArrGuideData[_iIndex].onClick();
        }

        public int[] getAllClickIndex()
        {
            if (!m_bInit) return;
            return null;
        }
    }
}
