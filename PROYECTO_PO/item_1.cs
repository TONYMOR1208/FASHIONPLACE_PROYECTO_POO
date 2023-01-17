class item_1 : Decorador
{
public item_1(OrdenBase ordenbase) : base(ordenbase)
{

}
public override double cuantificar()
{
  return base.cuantificar() + 80;
}
  //Creamos la clase Item_1
  //la cual permite realizar el calculo
  //del traje más el valor del Ítem
}
