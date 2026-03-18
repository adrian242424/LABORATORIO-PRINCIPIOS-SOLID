using System;

public class ReportProcessor2
{
    private readonly IFormatoReporte _formato;

    public ReportProcessor2(IFormatoReporte formato)
    {
        _formato = formato;
    }

    public void Process(string contenido)
    {
        var convertido = _formato.Convertir(contenido);
    }
}