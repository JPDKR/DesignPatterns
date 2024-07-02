namespace DesignPatterns.CSharp.Monads.Either
{
    public class Either<L, R>
    {
        public L? Left { get; }
        public R? Right { get; }
        public bool IsLeft { get; }
        public bool IsRight => !IsLeft;

        private Either(L? left, R? right, bool isLeft)
        {
            Left = left;
            Right = right;
            IsLeft = isLeft;
        }

        public static Either<L, R> LeftMethod(L left) => new(left, default, true);
        public static Either<L, R> RightMethod(R right) => new(default, right, false);
    }
}
