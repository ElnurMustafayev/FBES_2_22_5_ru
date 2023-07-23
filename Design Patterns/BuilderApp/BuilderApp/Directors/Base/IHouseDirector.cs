namespace BuilderApp.Directors.Base;

using BuilderApp.Builders.Base;
using BuilderApp.Models;

public interface IHouseDirector<THouse> where THouse : House {
    public void ChangeBuilder(IHouseBuilder<THouse> houseBuilder);
    public THouse Make();
}