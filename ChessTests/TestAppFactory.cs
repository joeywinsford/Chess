using Chess;

namespace ChessTests
{
    internal static class TestAppFactory
    {
        public static ChessApp Create()
        {
            return new ChessApp(new TestOutput());
        }
    }
}
