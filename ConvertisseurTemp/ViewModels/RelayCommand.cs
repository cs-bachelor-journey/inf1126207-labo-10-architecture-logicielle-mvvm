using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    // Predicate = fonction qui retourne bool (la condition d'activation)
    private readonly Predicate<object> _canExecute;

    // Action = ce qui s'exécute au clic (reçoit un paramètre object)
    private readonly Action<object> _execute;

    public RelayCommand(Predicate<object> canExecute, Action<object> execute)
    {
        _canExecute = canExecute;
        _execute = execute;
    }

    public bool CanExecute(object parameter) => _canExecute(parameter);
    public void Execute(object parameter) => _execute(parameter);

    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}