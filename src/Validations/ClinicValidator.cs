using FluentValidation;
using HospitalManagementSystem.API.src.Models.Domains;

namespace HospitalManagementSystem.API.src.Validators
{
    public class ClinicValidator : AbstractValidator<Clinic>
    {

        public ClinicValidator()
        {

            RuleFor(clinic => clinic.ClinicName).NotEmpty().WithMessage("Clinic name is required.");
            RuleFor(c => c.ClinicAddress).NotEmpty().WithMessage("Clinic address is required.");
            RuleFor(c => c.ClinicCity).NotEmpty().WithMessage("Clinic city is required.");
            RuleFor(c => c.ClinicState).NotEmpty().WithMessage("Clinic state is required.");
            RuleFor(c => c.ClinicPostalCode).NotEmpty().WithMessage("Clinic postal code is required.");
            RuleFor(c => c.ClinicCountry).NotEmpty().WithMessage("Clinic country is required.");
            RuleFor(c => c.ClinicPhoneNumber).NotEmpty().WithMessage("Clinic phone number is required.");
            RuleFor(c => c.ClinicEmail).NotEmpty().WithMessage("Clinic email is required.");
            RuleFor(c => c.ClinicWorkingHours).NotEmpty().WithMessage("Clinic working hours are required.");
        }
    }
}
