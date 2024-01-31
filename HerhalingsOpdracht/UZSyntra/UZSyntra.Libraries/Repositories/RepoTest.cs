using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UZSyntra.Data.Context;
using Microsoft.EntityFrameworkCore;
using UZSyntra.Data.Models;

namespace UZSyntra.Libraries.Repositories
{
    public class RepoTest
    {
        private UZSyntraContext _contextUZ = new UZSyntraContext(new DbContextOptions<UZSyntraContext>());

        public List<Patient> GetAllPatients()
        {
            return _contextUZ.Patients.ToList();
        }
    }

}
