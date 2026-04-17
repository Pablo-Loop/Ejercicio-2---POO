using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int damage); 
    float GettingHealth();            
    bool IsAlive(bool status);               
}
