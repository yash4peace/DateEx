// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DateTime EndDate = DateTime.Now;
EndDate = EndDate.AddDays(-10);
if (EndDate != new DateTime() && !string.IsNullOrEmpty(EndDate.ToString()))
{
    Console.WriteLine("EndDate is less than current date");
}
EndDate = EndDate.AddDays(10);
if (EndDate != new DateTime() && !string.IsNullOrEmpty(EndDate.ToString()))
{
    Console.WriteLine("EndDate is greater than current date");
}
