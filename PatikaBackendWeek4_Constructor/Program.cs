Baby baby1 = new Baby();
baby1.firstName = "Jane";
baby1.lastName = "Smith";
Console.WriteLine($"Baby 1: {baby1.firstName} {baby1.lastName}, Birth Date: {baby1.birthDate}");

Baby baby2 = new Baby("Oscar", "Wilson");
Console.WriteLine($"Baby 2: {baby2.firstName} {baby2.lastName}, Birth Date: {baby2.birthDate}");

