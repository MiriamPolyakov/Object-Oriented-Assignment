using System.Windows;
using System.Windows.Controls;

namespace Object_Orientae_Assignment;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void WatchAboutMe_Click(object sender, RoutedEventArgs e)
    {
        // Get the button that was clicked
        Button clickedButton = (Button)sender;

        Window animalWindow = new Animal(clickedButton.Name);
        animalWindow.Show();

    }
}
