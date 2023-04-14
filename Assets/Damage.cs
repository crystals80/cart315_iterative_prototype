using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private int obstacleDamage;
    [SerializeField] private Health _healthControl;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            DamageControl();
        }  
    }
    void DamageControl()
    {
        _healthControl.health = _healthControl.health - obstacleDamage;
        _healthControl.UpdateHealth();
        gameObject.SetActive(false);
    }
}
