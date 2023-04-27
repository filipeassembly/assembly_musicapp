namespace Assembly.MusicApp.Services.Contracts
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(int id);
        TEntity Delete(TEntity entity);

    }
}
