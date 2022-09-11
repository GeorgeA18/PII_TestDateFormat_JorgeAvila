namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static String ChangeFormat(string date)
    {
        // Condición por si los datos ingresados son vacios.
        if (!String.IsNullOrEmpty(date))
        {
            string dateCheker = "00/00/0000";
            string checker = "";
            // Convierte el stringe date pasado como parametro al formato de dateCheker para asi revisar que el formato sea correcto.
            foreach(char letter in date)
            {
                if(char.IsDigit(letter))
                {
                    checker += "0";
                }
                else
                {
                    checker +=  "/";
                }
            }
            // Verifica si el el tamaño del formato ingresado es el mismo que el correcto y si contiene los simbolos correctos.
            if (date.Length == 10 && dateCheker == checker)
            {
                string DateConverted = "";

                DateConverted =  $"{date} se convierte a {date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2)}";

                return DateConverted;
            }
            else
            {
                return "El formato no es valido.";
            }

        }
        else
        {
            return "Se ha ingresado un dato vacio.";
        }
    }
}
