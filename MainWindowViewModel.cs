using System.ComponentModel;

namespace MyAvoloniaApp;

public class MainWindowViewModel : INotifyPropertyChanged
{
    private string _buttonText = "Click Me!";

    public string ButtonText { 
        get => _buttonText;
        set 
        {
            _buttonText = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ButtonText)));
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void ButtonClicked() => ButtonText = "Hello, Avalonia!";
}
