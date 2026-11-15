using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tarea_3
{
    public class Cita
    {
        public Cita() { }
        public Cita(int id, DateTime dateandtime, string state, Doctor relateddoctor, Paciente relatedpacient)
        {
            Id = id;
            Dateandtime = dateandtime;
            State = state;
            RelatedDoctor = relateddoctor;
            RelatedPacient = relatedpacient;
        }
        public int Id { get; set; }
        public DateTime Dateandtime { get; set; }
        public string State { get; set; }
        public Doctor RelatedDoctor { get; set; }
        public Paciente RelatedPacient { get; set; }
        public override string ToString()
        {
            return $"{Id,-4}{RelatedPacient.Name,-30}{RelatedDoctor.Name,-30}{Dateandtime,-30}{State,-15}";
        }
        public static void ShowAll(List<Cita> Appointments)
        {
            Console.WriteLine("A continuación se mostrarán las citas listadas:");
            Console.WriteLine($"{"ID",-4}{"Paciente",-30}{"Doctor",-30}{"Fecha y hora",-30}{"Estado",-15}");
            foreach (Cita c in Appointments)
            {
                Console.WriteLine(c.ToString());
            }
        }
        public static void ShowOne(List<Cita> Appointments, int selector)
        {
            Cita c = Appointments.FirstOrDefault(c=> c.Id == selector);
            Console.WriteLine($"{"ID",-4}{"Paciente",-30}{"Doctor",-30}{"Fecha y hora",-30}{"Estado",-15}");
            Console.WriteLine(c.ToString());
        }

        public static void ChangeState(Cita Appointment)
        {
            Appointment.State = "Cancelada";
        }
    }
}
