using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class LightningSpell : MonoBehaviour, ISpell
{
    public void Cast() => Debug.Log("LightningSpell: Enel's Raigo");

    public class Factory : PlaceholderFactory<LightningSpell> { }
}
