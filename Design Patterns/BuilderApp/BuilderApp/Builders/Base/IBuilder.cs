namespace BuilderApp.Builders.Base;

public interface IBuilder<TEntity> {
    TEntity GetResult();
    void Reset();
}