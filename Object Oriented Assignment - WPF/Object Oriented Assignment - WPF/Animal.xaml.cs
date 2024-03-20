using Object_Oriented_Assignment;
using System;
using System.Windows;

namespace Object_Orientae_Assignment;

/// <summary>
/// Interaction logic for Animal.xaml
/// </summary>
public partial class Animal : Window
{
    public string animal; // Stores the currently selected animal
    Dog dog;
    Cat cat;
    Frog frog;

    /// <summary>
    /// the dog window with all of it options
    /// </summary>
    public void DogWindow()
    {
        this.dog = new Dog();
        animal = "Dog";
        AnimalName.Content = "Dog 🐶";
        GreetBtn.Visibility = Visibility.Visible;
        AnimalType.Content = dog.AnimalType;
        FeelComfortableBtn.IsEnabled = true;
        UpsetBtn.IsEnabled = true;
        GoodMoodBtn.IsEnabled = false;


    }

    /// <summary>
    /// the cat window with all of it options
    /// </summary>
    public void CatWindow()
    {
        this.cat = new Cat();
        animal = "Cat";
        AnimalName.Content = "Cat 😺";
        GreetBtn.Visibility = Visibility.Visible;
        AnimalType.Content = cat.AnimalType;
    }

    /// <summary>
    /// the frog window with all of it options
    /// </summary>
    public void FrogWindow()
    {
        this.frog = new Frog();
        animal = "Frog";
        AnimalName.Content = "Frog 🐸";
        GreetBtn.Visibility = Visibility.Hidden;
        isCarnivorous.Content = "✖";
        isMammal.Content = "✖";
        AnimalType.Content = frog.AnimalType;
    }

    /// <summary>
    /// Sets up the window for a specific animal (Dog, Cat, or Frog).
    /// </summary>
    /// <param name="animal">The animal to display ("Dog", "Cat", or "Frog").</param>
    public void selectWindow(string animal)
    {
        switch (animal)
        {
            case "DogBtn":
                DogWindow();
                break;
            case "CatBtn":
                CatWindow();
                break;
            case "FrogBtn":
                FrogWindow();
                break;
            default:
                break;
        }
    }
    public Animal(string animal)
    {

        InitializeComponent();
        selectWindow(animal);
    }

    /// <summary>
    /// Handles the click event for the "Greet" button.
    /// Displays a message box with the animal's greeting sound.
    /// </summary>
    private void GreetBtn_Click(object sender, RoutedEventArgs e)
    {
       
        switch (animal)
        {
            
            case "Dog":
                MessageBox.Show(dog.Greet(), "Dog greet", MessageBoxButton.OK, MessageBoxImage.Information);
                break;
            case "Cat":
                MessageBox.Show(cat.Greet(), "Cat greet", MessageBoxButton.OK, MessageBoxImage.Information);
                break;
            default:
                break;
        }

    }

    /// <summary>
    /// (Assuming FeelComfortableBtn is for Dog)
    /// Handles the click event for the "Feel Comfortable" button.
    /// Displays a message box with the dog's action when being touched comfortably.
    /// </summary>
    private void FeelComfortableBtn_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(dog.ComfortableBeingTouched(), "Dog feel comfortable", MessageBoxButton.OK, MessageBoxImage.Information);
        
    }

  
    /// <summary>
    /// Handles the click event for the "GoodMoodBtn" button.
    /// Displays a message box with the action when animal is in good mood .
    /// </summary>
    private void GoodMoodBtn_Click(object sender, RoutedEventArgs e)
    {
        switch (animal)
        {

            case "Frog":
                MessageBox.Show(frog.ActByFeeling(Emotion.GoodMood), "Frog is in good mood", MessageBoxButton.OK, MessageBoxImage.Information);
                break;
            case "Cat":
                MessageBox.Show(cat.ActByFeeling(Emotion.GoodMood), "Cat is in good mood", MessageBoxButton.OK, MessageBoxImage.Information);
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Handles the click event for the "FrightenedBtn" button.
    /// Displays a message box with the action when animal is frightened .
    /// </summary>
    private void FrightenedBtn_Click(object sender, RoutedEventArgs e)
    {
        switch (animal)
        {

            case "Frog":
                MessageBox.Show(frog.ActByFeeling(Emotion.Frightened), "Frog is frightened", MessageBoxButton.OK, MessageBoxImage.Information);
                break;
            case "Cat":
                MessageBox.Show(cat.ActByFeeling(Emotion.Frightened), "Cat is frightened", MessageBoxButton.OK, MessageBoxImage.Information);
                break;
            case "Dog":
                MessageBox.Show(dog.ActByFeeling(Emotion.Frightened), "Dog is frightened", MessageBoxButton.OK, MessageBoxImage.Information);
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Handles the click event for the "UpsetBtn" button.
    /// Displays a message box with the action when animal is upset .
    /// </summary>
    private void UpsetBtn_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(dog.ActByFeeling(Emotion.Upset), "Dog is upset", MessageBoxButton.OK, MessageBoxImage.Information);
      
    }

  
}
