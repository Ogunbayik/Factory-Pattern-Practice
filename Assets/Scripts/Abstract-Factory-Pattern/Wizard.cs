using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Wizard : MonoBehaviour
{
    private SpellFactory _spellFactory;

    [Inject]
    public void Construct(SpellFactory spellFactory) => _spellFactory = spellFactory;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            var spell = _spellFactory.Create(SpellType.Fire);
            spell.Cast();
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            var spell = _spellFactory.Create(SpellType.Ice);
            spell.Cast();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            var spell = _spellFactory.Create(SpellType.Lightning);
            spell.Cast();
        }
    }
}
