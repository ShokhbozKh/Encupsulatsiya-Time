namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hours = DateTime.Now.Hour;
            var minutes = DateTime.Now.Minute;
            var seconds = DateTime.Now.Second;

            Time time = new Time();
            time.Soat = hours;
            time.Minut = minutes;
            time.Sekund = seconds;

            time.DesplayInfo();
            
        }
    }
}