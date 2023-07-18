namespace FactoryMethodApp.Creators.Base;

using FactoryMethodApp.Models.Base;

public interface ICardCreator {
    Card Create();
}