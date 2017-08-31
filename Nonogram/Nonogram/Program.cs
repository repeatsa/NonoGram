
namespace Nonogram
{
    class Program
    {
        static void Main(string[] args)
        {
            //遊戲啟動
            NonogramMgr.Instance().startGame(null);
            //關閉遊戲
            NonogramMgr.Instance().closeGame();
        }
    }
}
