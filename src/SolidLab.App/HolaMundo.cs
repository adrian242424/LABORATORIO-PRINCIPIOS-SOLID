// using System;
// using System.IO;

var procesadorPDF = new ReportProcessor2(
            new FormatoJSON()
        );

        procesadorPDF.Process("Resumen de Ventas Q1");


// var processor = new ReportProcessor();
// processor.Process("Resumen de Ventas Q1", "PDF");

// public class ReportProcessor {
//     public void Process(string content, string format) {
//         // ¿Qué pasa si queremos agregar formato XML o Excel? 
//         // Estamos violando OCP y SRP aquí.
//         if (format == "PDF") {
//             Console.WriteLine("Convirtiendo a PDF...");
//         } else if (format == "JSON") {
//             Console.WriteLine("Convirtiendo a JSON...");
//         }

//         // ¿Qué pasa si queremos guardar en la Nube?
//         // Estamos violando DIP al depender de File.WriteAllText directamente.
//         File.WriteAllText("reporte.txt", content);
//         Console.WriteLine("Reporte guardado en disco.");
//     }
// }