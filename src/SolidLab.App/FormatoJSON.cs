public class FormatoJSON : IFormatoReporte
{
    public string Convertir(string contenido)
    {
        return $"{{ \"reporte\": \"{contenido}\" }}";
    }
}