using Tarea_3;
List<Paciente> Pacients = new List<Paciente>();
List<Doctor> Doctors = new List<Doctor>();
List<Cita> appointment = new List<Cita>();
bool Continue = true;
int Option = 0;

do
{
    Console.WriteLine("Bienvenido al programa de gestión de citas");
    Console.WriteLine("Seleccione la tarea que desea realizar:\n1.Registrar nuevo paciente.\n2.Registrar nuevo doctor.\n3.Generar nueva cita.\n4.Modificar cita.\n5.Cancelar una cita.\n6.Lista de citas existentes.\n7.Abandonar el programa.");
    try
    {
        Option = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Option = 0;
    }
    switch (Option)
    {
        case 1: 
            { 
                Helper.AddPaciente(Pacients);
                break; 
            }
        case 2:
            {
                Helper.AddDoctor(Doctors);
                break;
            }
        case 3:
            {
                Helper.AddCita(appointment, Pacients, Doctors);
                break;
            }
        case 4:
            {
                Helper.EditCita(appointment, Doctors);
                break;
            }
        case 5:
            {
                Helper.CancelCita(appointment);
                break;
            }
        case 6:
            {
                Cita.ShowAll(appointment);
                break;
            }
        case 7:
            {
                Continue = false;
                break;
            }
        default:
            {
                Console.WriteLine("La opción introducida no es valida, por favor, intente nuevamente");
                break;
            }
    }
} while (Continue);