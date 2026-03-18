public class FormatoPDF : IFormatoReporte
{
    public string Convertir(string contenido)
    {
        return $"[PDF] {contenido}";
    }
}