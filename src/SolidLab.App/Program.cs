using System;

var procesadorPDF = new ReportProcessor2(
            new FormatoJSON()
        );

        procesadorPDF.Process("Resumen de Ventas Q1");

// class Program
// {
//     static void Main()
//     {
//         // Cambia fácilmente el formato y almacenamiento (DIP)
//         var procesadorPDF = new ReportProcessor2(
//             new FormatoJSON()
//         );

//         procesadorPDF.Process("Resumen de Ventas Q1");

//     }
// }