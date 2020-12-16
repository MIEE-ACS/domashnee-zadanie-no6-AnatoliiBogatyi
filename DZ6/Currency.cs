namespace DZ6
{
    abstract class Currency
    {
        internal virtual decimal Amount { get; private protected set; }
        internal virtual decimal ToRub() => 0;
    }
}

