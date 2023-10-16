﻿using ADMISSION_PROCESS.Entity;

namespace ADMISSION_PROCESS.Repository.Interfaces
{
    public interface IRegistrationRepository
    {
        Registration GetRegistrationById(int Admin_ID);
        int AddRegistration(Registration registration);
        int UpdateRegistration(Registration registration);
        int DeleteRegistration(int Admin_ID);
    }
}
