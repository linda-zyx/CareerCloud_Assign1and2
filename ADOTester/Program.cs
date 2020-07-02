using CareerCloud.ADODataAccessLayer;
using System;

namespace ADOTester
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicantEducationRepository repo = new ApplicantEducationRepository();
            var res = repo.GetSingle(x => x.Id == Guid.Parse("40FAA097-3A8C-E7A0-896C-1255EAC6A6D2"));
            repo.Remove(res);
        }
    } 
}
