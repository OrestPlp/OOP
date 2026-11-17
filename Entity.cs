namespace LAB_3;
class Entity
{
    protected int _health;
    protected int _damage;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health < 0)
        {
            _health = 0;
        }
    }

    public int Attack(Entity target, Random rnd)
    {
        int damage = rnd.Next(1, _damage + 1);
        target.TakeDamage(damage);
        return damage;
    }

    public int health()
    {
        return _health;
    }
    public int damage()
    {
        return _damage;
    }
    

    public Entity(int health, int damage)
    {
        _health = health;
        _damage = damage;
    }

    
}