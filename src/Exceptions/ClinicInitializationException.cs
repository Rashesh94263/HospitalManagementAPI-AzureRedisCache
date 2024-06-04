namespace HospitalManagementSystem.API.src.Exceptions
{
    public class ClinicInitializationException : Exception
    {
        public ClinicInitializationException() { }

        public ClinicInitializationException(string message)
            : base(message) { }

        public ClinicInitializationException(string message, Exception err)
            : base(message, err) { }


    }
}
