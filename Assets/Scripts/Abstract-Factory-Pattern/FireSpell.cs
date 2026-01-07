using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class FireSpell : MonoBehaviour, ISpell
{
    public void Cast() => Debug.Log("FireSpell: Ace's Dai Enkai");

    public class Factory : PlaceholderFactory<FireSpell> { }
}
