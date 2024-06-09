using Calc.Services;

double result = new Calculator().Divide(10, null);

System.Console.WriteLine(result);




/*
src/.csproj
test/.csproj
.sln
*/

// bool canGetVisa = visaService.CanGetVisa(double? money, bool isMarried)

// Виза выдаётся только тем, кто не холост и у кого на счету >= 20k $