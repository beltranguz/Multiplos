
namespace Multiplos.Clase
{
    public class calcular
    {
        public void Multiplos()
        {
            int mul3 = 0;
            int mul5 = 0;
            int mul3y5 = 0;
            int valor = 0;
            int cantidad = 0;

            try
            {
                Console.WriteLine($"Digite la cantidad:");
                cantidad = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)

                {
                    Console.WriteLine($"Digite el valor: {i}");
                    valor = Convert.ToInt32(Console.ReadLine());

                    if ((valor % 3) == 0) ;
                    {
                        mul3++;
                    }

                    if ((valor % 5) == 0) ;
                    {
                        mul5++;
                    }

                     if ((valor %  3) == 0 && (valor % 5 == 0))
                    {
                        mul3y5++;
                    }
                    
                        {
                            Console.WriteLine($"Los Multiplos de 3 son: {mul3}");
                            mul3 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Los Multiplos de 5 son: {mul5}");
                            mul5 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine($"Los Multiplos de 3 y 5 son: {mul3y5}");
                            mul3y5 = Convert.ToInt32(Console.ReadLine());
                        }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en datos suministrados. {ex.Message}");
            }
        }


    }
 
}
