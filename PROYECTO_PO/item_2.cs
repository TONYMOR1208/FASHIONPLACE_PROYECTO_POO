class item_2:Decorador
{
public item_2(OrdenBase ordenbase) : base(ordenbase)
{

}
public override double cuantificar()
{
    return base.cuantificar() + 100;
}
    //Creamos la clase Item_2
    //la cual nos permite realizar el calculo
    //Del traje más el valor del Ítem
}  
