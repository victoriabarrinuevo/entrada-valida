Console.WriteLine("_Atividade entrada valida_");

int numerodigitado = -1;

while ( numerodigitado <= 0 || numerodigitado >= 9 )
{
     Console.WriteLine("Informe um número de 1 a 9 para continuar, ou digite 0 para cancelar. ");
     numerodigitado = Convert.ToInt32(Console.ReadLine());
}
if ( numerodigitado == 0 )
{
     Console.WriteLine("Sua operação foi cancelada, o número informado não pode ser utilizado.");
}
else 
{
     Console.WriteLine($"o número selecionado = {numerodigitado}");
}
Console.WriteLine("Obrigado.");