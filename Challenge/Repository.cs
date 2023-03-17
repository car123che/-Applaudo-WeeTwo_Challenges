namespace Challenge
{
    public class Repository<T, TKey> where T : IEntity<TKey>
    {
        private readonly Dictionary<TKey, T> _entities;

        public Repository()
        {
            _entities = new Dictionary<TKey, T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity.Id, entity);
        }

        public void Update(T entity)
        {
            _entities[entity.Id] = entity;
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity.Id);
        }

        public T Get(TKey id)
        {
            T entity = _entities[id];
            return entity;
        }

        public List<T> GetAll()
        {
            return _entities.Values.ToList();
        }

        public List<T> GetAll(Func<T, bool> filter )
        {
            return _entities.Values.Where(filter).ToList(); 
        }
    }

}