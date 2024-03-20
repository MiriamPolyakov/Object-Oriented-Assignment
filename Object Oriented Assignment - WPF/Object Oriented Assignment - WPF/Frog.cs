using System;
namespace Object_Oriented_Assignment;

internal class Frog : Animal
{
    public Frog() : base("terrestrial", false, false) { }
   
    public override string ActByFeeling(Emotion emotion)
    {
            switch (emotion)
            {
                case Emotion.Frightened:
                    return "plop into the water";

                case Emotion.GoodMood:
                    return "quack quack quack";


                default:
                    return "Invalid emotion provided.";

            }
       
    }

    public override string Greet()
    {
        throw new NotImplementedException();
    }
}
