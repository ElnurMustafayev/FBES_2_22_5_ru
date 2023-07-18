namespace PrototypeApp;

public interface IPrototype<T> {
    T Clone();
}