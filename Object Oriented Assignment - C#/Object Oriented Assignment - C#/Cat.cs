namespace Object_Oriented_Assignment;

internal class Cat : Animal
{
    public Cat() : base("terrestrial", true, true) { }
    public override string ActByFeeling(Emotion emotion)
    {
            switch (emotion)
            {
                case Emotion.Frightened:
                    return "hiss";
                                
                case Emotion.GoodMood:
                    return "purr, purr";

              
                default:
                   return "Invalid emotion provided.";

            }
         

    }

    public override string Greet()
    {
        return "meow~";
    }
}
