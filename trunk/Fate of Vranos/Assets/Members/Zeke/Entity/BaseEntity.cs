using UnityEngine;
using System.Collections;

// This is the base entity class for giving entities attributes (health, etc)
public interface BaseEntity
{
    string Name { get; set; }
    string Description { get; set; }

    float Health { get; set; }

    //void getHealth(); // May not be needed, not sure if interface get does this
    void takeDamage(float damageTaken);
}
