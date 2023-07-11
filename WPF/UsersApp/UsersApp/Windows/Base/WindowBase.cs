namespace UsersApp.Windows.Base;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

public class WindowBase : Window, INotifyPropertyChanged {
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void PropertyChangeMethod<T>(out T field, T value, [CallerMemberName] string propName = "") {
        field = value;

        if (this.PropertyChanged != null) {
            this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}