namespace BusinessLayer.Abstract;

public interface IGenericService<T>
{
    void TAdd(T entity);
    void TUpdate(T entity);
    void TDelete(T entity);
    List<T> TGetListAll();
    T TGetById(int id);
}