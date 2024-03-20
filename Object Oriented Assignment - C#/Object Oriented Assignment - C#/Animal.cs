namespace Object_Oriented_Assignment;

/// <summary>
/// This abstract class serves as the base class for various animal types.
/// It defines common properties and abstract methods for animal characteristics
/// and behaviors.
/// </summary>
internal abstract class Animal
{
    public string AnimalType { get; } = "terrestrial";  
    public bool IsMammal { get; }
    public bool IsCarnivorous { get; }

    protected Animal(string animalType, bool isMammal, bool isCarnivorous)
    {
        this.AnimalType = animalType;
        this.IsMammal = isMammal;
        this.IsCarnivorous = isCarnivorous;
    }

    /// <summary>
    /// Defines the sound or action an animal makes when greeting someone.
    /// </summary>
    /// <returns>A string representing the animal's greeting sound or action.</returns>
    public abstract string Greet();

    /// <summary>
    /// Defines the action an animal takes based on its emotional state.
    /// [
    /// </summary>
    /// <param name="emotion">The emotion the animal is experiencing.</param>
    /// <returns>A string describing the animal's action based on the provided emotion.</returns>
    public abstract string ActByFeeling(Emotion emotion);
}
