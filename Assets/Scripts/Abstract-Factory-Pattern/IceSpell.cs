using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class IceSpell : MonoBehaviour, ISpell
{
    public void Cast() => Debug.Log("IceSpell: Aokiji's Ice Age");

    public class Factory : PlaceholderFactory<IceSpell> { }
}
