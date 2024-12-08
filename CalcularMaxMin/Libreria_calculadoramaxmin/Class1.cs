
namespace Libreria_calcularmaxmin
{
    public class maxmin
    {

        public static float numeromax(float primerN, float segundoN, float tercerN)
     {
        float resultado = float.NaN;
        if (primerN >= segundoN)
        {
            if (primerN >= tercerN)
            {
                resultado = primerN;
            }
            else
            {
                resultado = tercerN;
            }
        }
        else
        {
            if (segundoN >= tercerN)
            {
                resultado = segundoN;
            }
            else
            {
                resultado = tercerN;
            }
        }

        //bucle que hace funcionar el programa

        return resultado;
     }
    public static float numeromin(float primerN, float segundoN, float tercerN)
    {
        float resultado = float.NaN;
        if (primerN <= segundoN)
        {
            if (primerN <= tercerN)
            {
                resultado = primerN;
            }
            else
            {
                resultado = tercerN;
            }
        }
        else
        {
            if (segundoN <= tercerN)
            {
                resultado = segundoN;
            }
            else
            {
                resultado = tercerN;
            }
        }

        //bucle que hace funcionar el programa

        return resultado;
    }
    }
}