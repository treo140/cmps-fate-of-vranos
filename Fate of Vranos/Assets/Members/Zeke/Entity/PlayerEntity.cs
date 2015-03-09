using UnityEngine;
using System.Collections;

public class PlayerEntity : BaseEntity 
{
    private float _health;

    public PlayerEntity()
    {
        Name = "Player";
        Description = "A description, possibly for no reason.";

        Health = 100.0f;

    }

    public string Name
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
            throw new System.NotImplementedException();
        }
    }

    public string Description
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
            throw new System.NotImplementedException();
        }
    }

 
    public float Health
    {
        get
        {
            return _health;
           // throw new System.NotImplementedException();
        }
        set
        {
            _health = value;
        }
    }


    public void takeDamage(float damageTaken)
    {
        _health = _health - damageTaken;
        throw new System.NotImplementedException();
    }
}
