namespace DesignPatterns.CSharp.Monads.MaybeOption
{
    public struct Maybe<T>
    {
        private readonly T _value;
        public readonly T Value => _value ?? throw new InvalidOperationException("No value present");
        public bool HasValue { get; }

        private Maybe(T value)
        {
            _value = value;
            HasValue = true;
        }

        public static Maybe<T> Some(T value) => new Maybe<T>(value);
        public static Maybe<T> None() => new();
    }
}
