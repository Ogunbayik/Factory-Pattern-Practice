using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpell 
{
    void Cast();
}

public enum SpellType
{
    Fire,
    Ice,
    Lightning
}
