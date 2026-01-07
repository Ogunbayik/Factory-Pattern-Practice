
public class SpellFactory 
{
    private readonly FireSpell.Factory _fireSpellFactory;
    private readonly IceSpell.Factory _iceSpellFactory;
    private readonly LightningSpell.Factory _lightningSpellFactory;

    public SpellFactory(FireSpell.Factory fireSpellFactory, IceSpell.Factory iceSpellFactory, LightningSpell.Factory lightningSpellFactory)
    {
        _fireSpellFactory = fireSpellFactory;
        _iceSpellFactory = iceSpellFactory;
        _lightningSpellFactory = lightningSpellFactory;
    }

    public ISpell Create(SpellType type)
    {
        switch(type)
        {
            case SpellType.Fire:
                return _fireSpellFactory.Create();
            case SpellType.Ice:
                return _iceSpellFactory.Create();
            case SpellType.Lightning:
                 return _lightningSpellFactory.Create();
            default:
                throw new System.ArgumentException("Tanýmsýz büyü tipi!");
        }
    }
}
