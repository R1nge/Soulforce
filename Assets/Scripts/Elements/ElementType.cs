namespace Elements
{
    //Decided to keep this enum, to avoid memory allocation for a class each time it gets passed
    public enum ElementType : byte
    {
        None,
        Electric,
        Fire, 
        Water
    }
}