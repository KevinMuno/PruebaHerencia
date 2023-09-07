using PruebaHerencia;

EmpleadoPorComision empleadoPorComision = new("Susana", "Lopez", "222-22-2222", .06M, 100000.00M);

Console.WriteLine("{0}: {1} {2}\n{3}: {4}\n",
    "Llama a ToString de EmpleadoPorComision con referencia de " + "clase base", "a objeto de clase base",
    empleadoPorComision.ToString(), "ingresos", empleadoPorComision.Ingresos());

EmpleadoBaseMasComision2 EmpleadoBaseMasComision = new("Roberto", "Perez", "333-33-3333", .04M, 5000.00M, 300.0M);

Console.WriteLine("{0}: {1} {2}\n{3}: {4}\n",
    "Llama a ToString de EmpleadoBaseMasComision con referencia de " + "clase base", "a objeto de clase base",
    EmpleadoBaseMasComision.ToString(), "ingresos", EmpleadoBaseMasComision.Ingresos());

EmpleadoPorComision empleadoPorComision2 = EmpleadoBaseMasComision;

Console.WriteLine("{0}: {1} {2}\n{3}: {4}\n",
    "Llama a ToString de EmpleadoBaseMasComision con referencia de " + "clase base", "a objeto de clase base",
   empleadoPorComision2.ToString(), "ingresos", empleadoPorComision2.Ingresos());

EmpleadoBaseMasComision.VentasBrutas = 4000.00M;
EmpleadoBaseMasComision.TarifaComision = .1M;
EmpleadoBaseMasComision.SalarioBase = 10000.00M;

Console.WriteLine("\n{0}:\n\n{1}",
    "Se actualizo la informacion del EmpleadoBaseMasComision por", "ToString", EmpleadoBaseMasComision);
Console.WriteLine("ingresos: {0:C}", EmpleadoBaseMasComision.Ingresos());


