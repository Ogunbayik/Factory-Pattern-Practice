
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpellFactory 
{
    public Dictionary<SpellType, Func<ISpell>> _spellMap;

    public SpellFactory(FireSpell.Factory fireSpellFactory, IceSpell.Factory iceSpellFactory, LightningSpell.Factory lightningSpellFactory)
    {
        _spellMap = new Dictionary<SpellType, Func<ISpell>>();

        _spellMap.Add(SpellType.Fire, () => fireSpellFactory.Create());
        _spellMap.Add(SpellType.Ice, () => iceSpellFactory.Create());
        _spellMap.Add(SpellType.Lightning, () => lightningSpellFactory.Create());
    }

    public ISpell Create(SpellType type)
    {
        if (_spellMap.TryGetValue(type, out Func<ISpell> createAction))
        {
            return createAction();
        }

        throw new ArgumentException($"SpellFactory: '{type}' is undefined!");
    }
}
