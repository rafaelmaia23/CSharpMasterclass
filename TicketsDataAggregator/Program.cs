using TicketsDataAggregator.FileAccess;
using TicketsDataAggregator.TicketsAggregatorApp;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

const string TicketsFolder = @"Tickets\";
try
{
    var ticketsAggregator = new TicketsAggregator(TicketsFolder,
        new FileWriter(),
        new DocumentsFromPdfsReader());

    ticketsAggregator.Run();
}
catch (Exception ex)
{
    Console.WriteLine("An exception occurred. Exception message: " + ex.Message);
}


Console.ReadLine();