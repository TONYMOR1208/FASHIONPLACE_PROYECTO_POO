class Ficha_Vendedor: Class_Padre
{
public string RequisitosLegales { set; get; }
public string DescripcionDelServicio { set; get; }
public string OpcionesDeVenta { set; get; }

public Ficha_Vendedor(int ID, int Cedula, string Nombre, string Apellido, string Correo, int Edad, int Telefono, string Direccion, string RequisitosLegales, string DescripcionDelServicio, string OpcionesDeVenta )       : base(ID, Cedula, Nombre, Apellido, Correo, Edad, Telefono, Direccion)
{
    this.RequisitosLegales = RequisitosLegales;
    this.DescripcionDelServicio = DescripcionDelServicio;
    this.OpcionesDeVenta = OpcionesDeVenta;
}
public override void ImprimirDatos()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Identificacion: " + ID);
    Console.WriteLine("Numero de Cedula " + Cedula);
    Console.WriteLine("Nombre : " + Nombre);
    Console.WriteLine("Apellidos :" + Apellido);
    Console.WriteLine("Edad  :" + Edad);
    Console.WriteLine("Correo Electronico :" + Correo);
    Console.WriteLine("Numero de telefono :" + Telefono);
    Console.WriteLine("Direccion del domicilio :" + Direccion);
    Console.WriteLine("");
     
    
}
public override void Servicio()
{
    Console.ForegroundColor = ConsoleColor.Blue; 
    Console.WriteLine("---------------------------------------------------");
    Console.WriteLine(" ---------BIENVENIDOS A FASHIONPLACE--------- ");
    Console.WriteLine("");

}
public override void legales()
{
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("Requisitos legales: " + RequisitosLegales);
    Console.WriteLine("");

}
public override void venta_boda()
{
    Console.WriteLine(OpcionesDeVenta);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Traje de todos los colores Midnight");
    Console.WriteLine("con tallas desde la 46 hasta la 58");
    Console.WriteLine("Leva Scatola Blu");
    Console.WriteLine("con tallas desde la 52 hasta la 56");
    Console.WriteLine("Traje Sand");
    Console.WriteLine("con tallas desde la 46 hasta la 58");
    Console.WriteLine();
}
public override void venta_quinceañera()
{
    Console.WriteLine(OpcionesDeVenta);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Traje de todos los coroles Midnight");
    Console.WriteLine("con tallas desde la 46 hasta la 58");
    Console.WriteLine("Leva Scatola Blu");
    Console.WriteLine("con tallas desde la 52 hasta la 56");
    Console.WriteLine("Traje Sand");
    Console.WriteLine("con tallas desde la 46 hasta la 58");
    Console.WriteLine();
}
public override void venta_bautizo()
{
    Console.WriteLine(OpcionesDeVenta);
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Traje de todos los coroles Midnight");
    Console.WriteLine("con tallas desde la 1 hasta la 58");
    Console.WriteLine("Leva Scatola Blu");
    Console.WriteLine("con tallas desde la 1 hasta la 56");
    Console.WriteLine("Traje Sand");
    Console.WriteLine("con tallas desde la 1 hasta la 58");
    Console.WriteLine();
}

}
