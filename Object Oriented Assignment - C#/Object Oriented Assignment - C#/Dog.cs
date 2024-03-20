namespace Object_Oriented_Assignment;

internal class Dog : Animal
{
    public Dog() : base("terrestrial", true, true) { }

    public override string ActByFeeling(Emotion emotion)
    {

            switch (emotion)
            {
                case Emotion.Frightened :
                case Emotion.Upset:
                    return "whooping";

                default:
                    return "Invalid emotion provided.";

            }
        
    }

    public override string Greet()
    {
        return "wagging dog's tails";
    }



    /// <summary>
    /// (ComfortableBeingTouched is for Dog only!)
    /// dog's action when being touched comfortably.
    /// </summary>
    /// <returns>The dog's action when being touched comfortably.</returns>
    public string ComfortableBeingTouched()
    {
        return "bark loudly!!";
    }
}
